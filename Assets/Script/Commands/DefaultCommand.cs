using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Kepler/Commands/DefaultCommand")]
public class DefaultCommand : Command {
    public override void Execute(string input) {
        gm.terminal.LogSystemMessage (
            answer.ReplaceCaseInsensitive("XXX", input.Split(' ')[0]));
    }

    public override void LogWrongArgumentAnswer(string input) {
        gm.terminal.LogSystemMessage ("error: trying to log bad argument message for default command");
    }
}