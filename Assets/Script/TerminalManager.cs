using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TerminalManager : MonoBehaviour {
    public static TerminalManager instance;
    public TextMeshProUGUI log;
    public TMP_InputField inputField;
    public List<Command> commands;
    public Command defaultCommand;
    public float lettersPerSec;

    private void Start () {
        ResetInputField ();
        ClearLog();
        instance = this;
    }

    private void Update () {
        if (Input.GetKeyDown(KeyCode.Return)) SubmitInput(inputField.text);
    }

    private void SubmitInput (string input) {
        ResetInputField ();

        if (input != "") {
            input = input.ToLower();
            LogPlayerCommand(input);
            Parse(input);
        }
    }

    private void ResetInputField () {
        inputField.ActivateInputField();
        inputField.text = null;
    }

    public void LogPlayerCommand (string text) {
        AddToLog("\n> "+text);
    }

    public void LogSystemAnswer (string text) {
        StartCoroutine(_LogSystemAnswer("\n"+text+"\n"));
    }

    private IEnumerator _LogSystemAnswer (string text) {
        AddToLog ("");
        for (int i=0; i<text.Length; i++) {
            yield return new WaitForSeconds (1/lettersPerSec);
            AddToLog(text[i].ToString());
        }
    }

    private void AddToLog (string text) {
        log.text += text;
    }

    private void ClearLog () {
        log.text = "";
    }

    private void Parse (string input) {
        string [] words = input.Split(new char[] {' '});

        bool answered = false;
        foreach (Command command in commands) {
            foreach (string verb in command.verbs) {
                if (words[0] == verb.ToLower()) {
                    command.Execute(words);
                    answered = true;
                    break;
                }
            }
        }

        if (!answered) {
            defaultCommand.Execute(words);
        }
    }
}