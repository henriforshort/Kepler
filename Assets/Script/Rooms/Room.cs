using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Kepler/Room")]
public class Room : ScriptableObject {
    public List<Exit> exits;
    [TextArea]
    public string description;
}