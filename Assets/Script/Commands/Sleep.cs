﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Kepler/Commands/Sleep")]
public class Sleep : Command {
    public override void Execute(string verb, string noun) {
        TerminalManager.instance.LogSystemMessage ("putting " + noun + " to sleep");
    }
}