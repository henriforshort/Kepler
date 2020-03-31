using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Kepler/Commands/Go")]
public class Go : Command {
    public Room nextRoom;
    public override void Execute(string input) {
        gm.rooms.EnterRoom(nextRoom);
    }
}