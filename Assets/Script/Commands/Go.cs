using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Kepler/Commands/Go")]
public class Go : Command {
    public override void Initialize() {
        nouns.Clear();
        foreach (Exit exit in gm.rooms.currentRoom.exits) {
            nouns.Add(exit.direction.Trim());
        }
    }

    public override void Execute(string input) {
        foreach (Exit exit in gm.rooms.currentRoom.exits) {
            if (exit.direction.EqualsCaseInsensitive(input.GetNoun(this))) {
                gm.rooms.EnterRoom(exit.nextRoom);
            }
        }
    }
}