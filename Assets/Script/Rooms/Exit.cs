using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Exit {
    public List<Command> commands;
    public Room nextRoom;
}