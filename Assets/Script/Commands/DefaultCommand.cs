using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Kepler/Commands/DefaultCommand")]
public class DefaultCommand : Command {
    public override void Execute(string verb, string noun) {
        TerminalManager.instance.LogSystemMessage ("input not recognized");
    }
}