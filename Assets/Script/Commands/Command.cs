using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public abstract class Command : ScriptableObject {
    public List<string> verbs;

    public abstract void Execute (string[] words);

    protected void Log (string text) {
        TerminalManager.instance.LogSystemAnswer(text);
    }

    protected string Nouns (string[] words) {
        return string.Join(" ", words);
    }

    protected string Nouns (string[] words, int exceptThisOne) {
        return string.Join(" ", words.Where(w => w != words[exceptThisOne]).ToArray());
    }
}