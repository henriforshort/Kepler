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
    
    //--------------------
    // VIRTUAL METHODS
    //--------------------
    
    public virtual void Initialize () { }

    public virtual void Execute(string input) {
        gm.terminal.LogSystemMessage (answer.ReplaceCaseInsensitive("XXX", input.GetNoun(this)));
    }

    public virtual void LogWrongArgumentAnswer(string input) {
        gm.terminal.LogSystemMessage (wrongArgumentAnswer.ReplaceCaseInsensitive("XXX", input.GetNoun(this)));
    }
}