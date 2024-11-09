using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "S_Gacha", menuName = "ScriptableObjects/Gacha")]
public class S_Gacha : ScriptableObject
{
    public new string name;
    public bool collected;
    public int amount;
}
