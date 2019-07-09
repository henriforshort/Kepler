using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TerminalManager : MonoBehaviour {
    [Header("CONTENT")]
    public float lettersPerSec;

    [Header("REFERENCES")]
    public TextMeshProUGUI log;
    public TMP_InputField inputField;
    
    //[Header("STATE")]

    [HideInInspector]
    public static TerminalManager instance;

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
            LogPlayerCommand(input);
            ParsingManager.instance.Parse(input);
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
        foreach (char letter in text) {
            yield return new WaitForSeconds (1/lettersPerSec);
            AddToLog(letter.ToString());
        }
    }

    private void AddToLog (string text) {
        log.text += text;
    }

    private void ClearLog () {
        log.text = null;
    }
}