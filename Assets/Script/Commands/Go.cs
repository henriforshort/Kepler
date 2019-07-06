using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Kepler/Actions/Go")]
public class Go : Command {
    public override void Execute(string[] words) {
        Log ("Going "+Nouns(words, 0));
    }
}