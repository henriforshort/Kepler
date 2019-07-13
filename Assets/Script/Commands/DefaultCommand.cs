using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Kepler/Commands/DefaultCommand")]
public class DefaultCommand : Command {
    public override void Execute(string verb, string noun) {
        gm.terminal.LogSystemMessage ("input not recognized");
    }
}