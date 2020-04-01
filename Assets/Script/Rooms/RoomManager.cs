using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour {
    public Room currentRoom;

    //SHORTCUTS
    public GameManager gm { get { return GameManager.instance; } }

    public void Start() {
        EnterRoom(currentRoom);
    }

    public void EnterRoom (Room room) {
        currentRoom = room;
        gm.terminal.LogSystemMessage(currentRoom.description);
        foreach (Command command in currentRoom.commands) {
            command.Initialize();
        }
    }
}