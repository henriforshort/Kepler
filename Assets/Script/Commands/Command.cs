using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//1 command per effect (Execute method)
//1 instance per verb/noun set (i.e 1 instance per Execute method+parameters)

public abstract class Command : ScriptableObject {
    [Header("CONTENT")]
    public List<string> verbs;
    public List<string> nouns;
    public string answer;
    public string wrongArgumentAnswer;

    //SHORTCUTS
    public GameManager gm { get { return GameManager.instance; } }

    public virtual void Execute(string input) {
        gm.terminal.LogSystemMessage (answer.Replace("XXX", GetNoun(input)));
    }

    public virtual void LogWrongArgumentAnswer(string input) {
        gm.terminal.LogSystemMessage (wrongArgumentAnswer.Replace("XXX", GetNoun(input)));
    }

    public bool ContainsVerb(string input) {
        foreach (string verb in verbs) {
            if (input.StartsWith(verb)) {
                return true;
            }
        }
        return false;
    }

    public bool IsValid(string input) {
        return ContainsVerb(input) && nouns.Contains(GetNoun(input));
    }

    public string GetVerb(string input) {
        input = input.Trim();
        foreach (string verb in verbs) {
            if (input.StartsWith(verb)) {
                return verb;
            }
        }
        return input.Split(' ')[0];
    }

    public string GetNoun(string input) {
        return input.Replace(GetVerb(input), "").Trim();
    }
}