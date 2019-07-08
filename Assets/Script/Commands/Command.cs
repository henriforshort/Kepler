using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public abstract class Command : ScriptableObject {
    public List<string> verbs;

    public abstract void Execute (string input);

    protected void Log (string text) {
        TerminalManager.instance.LogSystemAnswer(text);
    }

    protected string RemoveWord (string input, string wordToRemove) {
        List<string> words = input.Split(new char[] {' '}).ToList();
        foreach (string w in words) {
            if (w.ToLower() == wordToRemove.ToLower()) {
                words.Remove(w);
            }
        }

        return string.Join(" ", words.ToArray());
    }

    protected string RemoveWords (string input, List<string> wordsToRemove) {
        foreach (string word in wordsToRemove) {
            input = RemoveWord(input, word);
        }

        return input;
    }

    protected string RemoveVerbs (string input) {
        return RemoveWords(input, verbs);
    }
}