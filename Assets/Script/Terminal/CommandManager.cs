using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandManager : MonoBehaviour {
    [Header("CONTENT")]
    public Command defaultCommand;

    //[Header("REFERENCES")]

    //SHORTCUTS
    public GameManager gm { get { return GameManager.instance; } }

    public void Parse (string input) {
        Command commandWithBadArguments = null;
        foreach (Command command in gm.rooms.currentRoom.commands) {
            if (command.IsValid(input)) {
                command.Execute(input);
                return;
            } else if (command.ContainsVerb(input)) {
                commandWithBadArguments = command;
            }
        }
        if (commandWithBadArguments != null) {
            commandWithBadArguments.LogWrongArgumentAnswer(input);
        } else {
            defaultCommand.Execute(input);
        }
    }
}