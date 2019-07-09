using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Kepler/Room")]
public class Room : ScriptableObject {
    public List<Command> commands;
    [TextArea]
    public string description;
}