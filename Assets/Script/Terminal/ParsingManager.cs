using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ParsingManager : MonoBehaviour {
    [Header("CONTENT")]
    public Command defaultCommand;

    //[Header("REFERENCES")]

    [Header("STATE")]
    public List<string> possibleWords;

    //SHORTCUTS
    public GameManager gm { get { return GameManager.instance; } }
    
    //--------------------
    // BASIC METHODS
    //--------------------

    public void Update() {
        SetPredictiveText();
    }
    
    //--------------------
    // PARSING
    //--------------------

    public void Parse (string input) {
        input = input.ToLower();
        if (GetValidCommands(input).Count > 0) GetValidCommands(input)[0].Execute(input);
        else  if (GetPossibleCommands(input).Count > 0) GetPossibleCommands(input)[0].LogWrongArgumentAnswer(input);
        else defaultCommand.Execute(input);
    }
    
    //--------------------
    // PREDICTIVE TEXT
    //--------------------

    public void SetPredictiveText() {
        possibleWords.Clear();
        
        if (GetValidCommands(gm.terminal.inputField.text).Count > 0) possibleWords.Clear();
        else if (GetPossibleCommands(gm.terminal.inputField.text).Count > 0) {
            foreach (Command command in GetPossibleCommands(gm.terminal.inputField.text)) {
                possibleWords.AddRange(command.nouns);
            }
        } else {
            foreach (Command command in gm.rooms.currentRoom.commands) {
                possibleWords.AddRange(command.verbs);
            }
        }
        
        gm.terminal.predictiveText.text = string.Join("    ", possibleWords.Take(3));
    }
    
    //--------------------
    // UTILS
    //--------------------

    public List<Command> GetPossibleCommands(string input) {
        return gm.rooms.currentRoom.commands.Where(input.ContainsVerb).ToList();
    }

    public List<Command> GetValidCommands(string input) {
        return gm.rooms.currentRoom.commands.Where(input.IsValid).ToList();
    }
}