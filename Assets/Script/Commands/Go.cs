using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Kepler/Actions/Go")]
public class Go : Command {
    public Room nextRoom;
    public override void Execute() {
        TerminalManager.instance.LogSystemAnswer ("Going " + nouns[0]);
        RoomManager.instance.EnterRoom(nextRoom);
    }
}