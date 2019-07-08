using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParsingManager : MonoBehaviour {
    public static ParsingManager instance;
    public List<Command> commands;

    private void Start () {
        instance = this;
    }

    private void Parse (string input) {
        string [] words = input.Split(new char[] {' '});

        bool answered = false;
        foreach (Command command in commands) {
            foreach (string verb in command.verbs) {
                if (words[0] == verb.ToLower()) {
                    command.Execute(input);
                    answered = true;
                    break;
                }
            }
        }

        if (!answered) {
            defaultCommand.Execute(input);
        }
    }
}