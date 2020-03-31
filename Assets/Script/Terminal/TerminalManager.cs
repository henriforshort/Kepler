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
    
    //--------------------
    // BASIC METHODS
    //--------------------

    private void Start () {
        ClearInputField ();
        ClearLog();
        StartCoroutine(StartTerminal());
        LogSystemMessage(gm.rooms.currentRoom.description);
    }

    private void Update () {
        if (Input.GetKeyDown(KeyCode.Return)) {
            if (textToDisplay.Count == 0) {
                SubmitInput(inputField.text);
            } else {
                foreach (char character in textToDisplay) {
                    AddToLog(character);
                }
                textToDisplay.Clear();
            }
        }
    }
    
    //--------------------
    // PUBLIC METHODS
    //--------------------

    public void LogPlayerCommand (string text) {
        AddToLogYellow("\n\n> "+text);
    }

    public void LogSystemMessage (string text) {
        textToDisplay.AddRange(("\n"+text+"").ToList());
    }
    
    //--------------------
    // PRIVATE METHODS
    //--------------------

    private IEnumerator StartTerminal () {
        while (true) {
            yield return new WaitForSeconds (1/lettersPerSec);
            
            if (textToDisplay.Count != 0) {
                AddToLog(textToDisplay[0]);
                textToDisplay.RemoveAt(0);
            }
        }
    }

    private void SubmitInput (string input) {
        ClearInputField ();

        input = input.Trim();
        if (input != "") {
            LogPlayerCommand(input);
            gm.commands.Parse(input);
        }
    }

    private void AddToLog (char characterToAdd) {
        log.text += characterToAdd;
    }

    private void AddToLogYellow (string text) {
        log.text += "<color=\"yellow\">" + text + "</color=\"yellow\">";
    }    

    private void ClearLog () {
        log.text = null;
    }

    private void ClearInputField () {
        inputField.ActivateInputField();
        inputField.text = null;
    }
}