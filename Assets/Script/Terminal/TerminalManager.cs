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

    [HideInInspector]
    public static TerminalManager instance;

    private void Start () {
        ResetInputField ();
        ClearLog();
        instance = this;
        LogSystemMessage(RoomManager.instance.currentRoom.description);
    }

    private void Update () {
        if (Input.GetKeyDown(KeyCode.Return) && textToDisplay.Count == 0) SubmitInput(inputField.text);
    }

    private void SubmitInput (string input) {
        ResetInputField ();

        if (input != "") {
            LogPlayerCommand(input);
            ParsingManager.instance.Parse(input);
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
        if (textToDisplay.Count == 0) {
            StartCoroutine(_LogSystemAnswer("\n"+text+""));
        } else {
            textToDisplay.AddRange(("\n"+text+"").ToList());
        }
    }

    private IEnumerator _LogSystemAnswer (string text) {
        textToDisplay.AddRange((text).ToList());
        while (textToDisplay.Count > 0) {
            yield return new WaitForSeconds (1/lettersPerSec);
            AddToLog(textToDisplay[0].ToString());
            textToDisplay.RemoveAt(0);
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