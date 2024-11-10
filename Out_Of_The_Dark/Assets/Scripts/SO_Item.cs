using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://www.youtube.com/watch?v=_IqTeruf3-s&list=PLJWSdH2kAe_Ij7d7ZFR2NIW8QCJE74CyT scriptable objects

public enum ItemType
{
    Category,
    Plant,
    Seed,
    Default
}


[CreateAssetMenu(fileName = "SO_Item", menuName = "ScriptableObjects/Items")]
public class SO_Item : ScriptableObject
{
    public ItemType itemType;
}
