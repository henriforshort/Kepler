﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Kepler/Commands/Wake")]
public class Wake : Command {
    public override void Execute (string verb, string noun) {
        gm.terminal.LogSystemMessage ("Unfreezing " + noun);
    }
}