using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParsingManager : MonoBehaviour {
    [Header("CONTENT")]
    public List<Command> commands;
    public Command defaultCommand;

    //[Header("REFERENCES")]

    //[Header("STATE")]

    [HideInInspector]
    public static ParsingManager instance;

    private void Start () {
        instance = this;
    }

    public void Parse (string input) {
        foreach (Command command in RoomManager.instance.currentRoom.commands) {
            if (command.CanParse(input)) {
                command.Execute();
                return null;
            }
        }

        defaultCommand.Execute();
    }
}