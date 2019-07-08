using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Kepler/Actions/Sleep")]
public class Sleep : Command {
    public override void Execute(string input) {
        Log ("putting " + RemoveVerbs(input) + " to sleep");
    }
}