using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://www.youtube.com/watch?v=_IqTeruf3-s&list=PLJWSdH2kAe_Ij7d7ZFR2NIW8QCJE74CyT scriptable objects

public enum CategoryType
{
    Herb,
    Flower,
    Climber,
    Tree,
    Creeper,
    Bush,
    Root,
    Weed
}


[CreateAssetMenu(fileName = "SO_Category", menuName = "ScriptableObjects/Items/Category")]
public class SO_Category : SO_Item
{
    public new string name;
    public int total;
    public int revealed;
    public Sprite image;
    [TextArea(10, 10)] //sets the box size in inspector
    public string note;

    public void Awake()
    {
        itemType = ItemType.Category;
    }

}
