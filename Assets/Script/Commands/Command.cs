using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

//1 command per effect (Execute method)
//1 instance per verb/noun set (i.e 1 instance per Execute method+parameters)

public abstract class Command : ScriptableObject {
    public List<string> verbs;
    public List<string> nouns;

    //SHORTCUTS
    public GameManager gm { get { return GameManager.instance; } }

    public abstract void Execute (string verb, string noun);
}