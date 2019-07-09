using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ParsingManager : MonoBehaviour {
    [Header("CONTENT")]
    public Command defaultCommand;

    //[Header("REFERENCES")]

    //[Header("STATE")]

    [HideInInspector]
    public static ParsingManager instance;

    private void Start () {
        instance = this;
    }

    public void Parse (string input) {
        List<string> inputWords = input.ToLower().Split(new char[] {' '}).ToList();
        foreach (Command command in RoomManager.instance.currentRoom.commands) {

            //Parse verb
            foreach (string verb in command.verbs) {
                if (inputWords.Contains(verb.ToLower())) { //TODO : method containsSequence for multi-word verbs

                    //Parse noun
                    foreach (string noun in command.nouns) {
                        if (inputWords.Contains(noun.ToLower())) {
                            command.Execute(verb, noun);
                            return;
                        }
                    }

                }
            }
        }

        defaultCommand.Execute(null, null);
    }
}