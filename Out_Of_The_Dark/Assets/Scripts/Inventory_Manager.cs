using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;


//https://www.youtube.com/watch?v=AoD_F1fSFFg
public class Inventory_Manager : MonoBehaviour
{
    public static Inventory_Manager Instance;
    public List<SO_Plants> plants = new List<SO_Plants>();

    private void Awake()
    {
        Instance = this;
    }

    public void Add(SO_Plants plant)
    {
        plants.Add(plant);
    }

    public void Remove(SO_Plants plant)
    {
       plants.Remove(plant);
    }


}
