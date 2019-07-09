using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

//1 command per effect (Execute method)
//1 instance per verb/noun set (i.e 1 instance per Execute method+parameters)

public abstract class Command : ScriptableObject {
    public List<string> verbs;
    public List<string> nouns;

    public abstract void Execute (string verb, string noun);
}