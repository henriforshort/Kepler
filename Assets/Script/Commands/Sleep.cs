using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Kepler/Actions/Sleep")]
public class Sleep : Command {
    public override void Execute() {
        TerminalManager.instance.LogSystemAnswer ("putting " + nouns[0] + " to sleep");
    }
}