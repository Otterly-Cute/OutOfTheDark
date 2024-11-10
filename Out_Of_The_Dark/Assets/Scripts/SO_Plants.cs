using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://www.youtube.com/watch?v=_IqTeruf3-s&list=PLJWSdH2kAe_Ij7d7ZFR2NIW8QCJE74CyT scriptable objects

[CreateAssetMenu(fileName = "SO_Plants", menuName = "ScriptableObjects/Items/Plant")]
public class SO_Plants : SO_Item
{
    public CategoryType categoryType;

    public new string name;  
    [TextArea(10, 10)] //sets the box size in inspector
    public string description;
    public int rank;

    public GameObject prefab;
    public Sprite image;

    [HideInInspector] public int minGrowth = 0;
    [HideInInspector] public int maxGrowth = 100;
    [HideInInspector] public int minHealth = 0;
    [HideInInspector] public int maxHealth = 100;

    

    public void Awake()
    {
        itemType = ItemType.Plant;
    }

}
