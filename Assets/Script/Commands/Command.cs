using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

//1 command per effect (Execute method)
//1 instance per verb/noun set (i.e 1 instance per Execute method+parameters)

public abstract class Command : ScriptableObject {
    public List<string> verbs;
    public List<string> nouns;

    public abstract void Execute ();

    public bool CanParse (string input) {
        List<string> inputWords = input.ToLower().Split(new char[] {' '}).ToList();

        //Parse verb
        bool containsVerb = true;
        foreach (string verb in verbs) {
            if (inputWords.Contains(verb.ToLower())) { //TODO : method containsSequence for multi-word verbs

                //Parse noun
                foreach (string noun in nouns) {
                    if (inputWords.Contains(noun.ToLower())) {
                        return true;
                    }
                }

            }
        }

        return false;
    }
}