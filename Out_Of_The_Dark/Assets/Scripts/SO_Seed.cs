using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://www.youtube.com/watch?v=_IqTeruf3-s&list=PLJWSdH2kAe_Ij7d7ZFR2NIW8QCJE74CyT scriptable objects

[CreateAssetMenu(fileName = "SO_Seed", menuName = "ScriptableObjects/Items/Seed")]
public class SO_Seed : SO_Item
{
    public new string name;
    public string rank;
    public int amount;
    public bool discovered;
    public Sprite image;
    public float dropRate;

    public void Awake()
    {
        itemType = ItemType.Seed;
    }
}
