using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;

public class TerminalManager : MonoBehaviour {
    [Header("CONTENT")]
    public float lettersPerSec;

    [Header("REFERENCES")]
    public TextMeshProUGUI log;
    public TMP_InputField inputField;
    
    [Header("STATE")]
    public List<char> textToDisplay = new List<char>();

    //SHORTCUTS
    public GameManager gm { get { return GameManager.instance; } }

    private void Start () {
        ResetInputField ();
        ClearLog();
        StartCoroutine(StartTerminal());
        LogSystemMessage(gm.rooms.currentRoom.description);
    }

    private void Update () {
        if (Input.GetKeyDown(KeyCode.Return) && textToDisplay.Count == 0) SubmitInput(inputField.text);
    }

    private void SubmitInput (string input) {
        ResetInputField ();

        if (input != "") {
            LogPlayerCommand(input);
            gm.parser.Parse(input);
        }
    }

    private void ResetInputField () {
        inputField.ActivateInputField();
        inputField.text = null;
    }

    public void LogPlayerCommand (string text) {
        AddToLogYellow("\n\n> "+text);
    }

    public void LogSystemMessage (string text) {
        textToDisplay.AddRange(("\n"+text+"").ToList());
    }

    private IEnumerator StartTerminal () {
        while (true) {
            yield return new WaitForSeconds (1/lettersPerSec);
            
            if (textToDisplay.Count != 0) {
                AddToLog(textToDisplay[0].ToString());
                textToDisplay.RemoveAt(0);
            }
        }
    }

    private void AddToLog (string text) {
        log.text += text;
    }

    private void AddToLogYellow (string text) {
        log.text += "<color=\"yellow\">" + text + "</color=\"yellow\">";
    }    

    private void ClearLog () {
        log.text = null;
    }
}