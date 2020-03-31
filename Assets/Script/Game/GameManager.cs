﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class GameManager : MonoBehaviour {
    public static GameManager instance;

    public void Awake () {
        if (instance == null) instance = this;
        if (instance != this) Destroy (this);
    }

    public void OnDestroy () {
        if (instance == this) instance = null;
    }

    public CommandManager commands;
    public RoomManager rooms;
    public TerminalManager terminal;
}