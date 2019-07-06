using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;

public class TerminalManager : MonoBehaviour {
    public static TerminalManager instance;
    public List<string> log;
    public TextMeshProUGUI logObject;
    public TMP_InputField inputField;
    public List<Command> commands;
    public Command defaultCommand;
    public float lettersPerSec;

    private void Start () {
        ResetInputField ();
        DisplayLog ();
        instance = this;
    }

    private void Update () {
        if (Input.GetKeyDown(KeyCode.A)) {
            DisplayLog();
        }

        if (Input.GetKeyDown(KeyCode.Return)) SubmitInput(inputField.text);
    }

    private void SubmitInput (string input) {
        ResetInputField ();

        if (input != "") {
            input = input.ToLower();
            AddToLog("");
            AddToLog ("> "+input);
            Parse(input);
            DisplayLog();
        }
    }

    private void ResetInputField () {
        inputField.ActivateInputField();
        inputField.text = null;
    }

    public void AddToLog (string text) {
        log.Add(text);
    }

    private void DisplayLog () {
        logObject.text = string.Join("\n", log.ToArray());
    }

    private void Parse (string input) {
        string [] words = input.Split(new char[] {' '});

        bool answered = false;
        foreach (Command command in commands) {
            if (words[0] == command.verb.ToLower()) {
                command.Execute(words);
                answered = true;
            }
        }

        if (!answered) {
            defaultCommand.Execute(words);
        }
    }

    public void WriteSlow (string text) { StartCoroutine(_WriteSlow(text)); }
    public IEnumerator _WriteSlow (string text) {
        AddToLog ("");
        for (int i=0; i<text.Length; i++) {
            yield return new WaitForSeconds (1/lettersPerSec);
            log[log.Count - 1] += text[i];
            DisplayLog();
        }
    }
}