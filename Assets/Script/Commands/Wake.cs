using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Kepler/Actions/Wake")]
public class Wake : Command {
    public override void Execute (string[] words) {
        Log ("Unfreezing "+Nouns(words, 0));
    }
}