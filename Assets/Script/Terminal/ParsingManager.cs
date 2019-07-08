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
        string [] words = input.Split(new char[] {' '});

        bool answered = false;

        foreach (Exit exit in RoomManager.instance.currentRoom.exits) {
            foreach (Command command in exit.commands) {
                foreach (string verb in command.verbs) {
                    if (words[0].ToLower() == verb.ToLower()) {
                        command.Execute(input);
                        RoomManager.instance.EnterRoom(exit.nextRoom);
                        answered = true;
                        break;
                    }
                }
                if (answered) break;
            }
            if (answered) break;
        }

        if (!answered) {
            defaultCommand.Execute(input);
        }
    }
}