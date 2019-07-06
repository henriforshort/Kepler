using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[CreateAssetMenu(menuName="Kepler/Actions/Sleep")]
public class Sleep : Command {
    public override void Execute(string[] words) {
        Log ("putting "+string.Join(" ", Nouns(words, 0))+" to sleep");
    }
}