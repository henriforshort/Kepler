﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Kepler/Actions/DefaultCommand")]
public class DefaultCommand : Command {
    public override void Execute(string input) {
        Log (input[0]+" : input not recognized");
    }
}