using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Kepler/Commands/DefaultCommand")]
public class DefaultCommand : Command {
    public override void Execute(string input) {
        base.Execute(input.Split(' ')[0]);
    }

    public override void LogWrongArgumentAnswer(string input) {
        gm.terminal.LogSystemMessage ("error: trying to log bad argument message for default command");
    }
}