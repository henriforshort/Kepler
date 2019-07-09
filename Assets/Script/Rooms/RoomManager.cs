using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour {
    public Room currentRoom;
    public static RoomManager instance;

    private void Start () {
        instance = this;
    }

    public void EnterRoom (Room room) {
        currentRoom = room;
        TerminalManager.instance.LogSystemMessage(currentRoom.description);
    }
}