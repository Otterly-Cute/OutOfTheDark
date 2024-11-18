using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://www.youtube.com/watch?v=AoD_F1fSFFg

public class Item_Pickup : MonoBehaviour
{
   public SO_Plants plants;

    void Pickup()
    {
        Inventory_Manager.Instance.Add(plants);
        Destroy(gameObject);
    }

    private void OnMouseDown()
    {
        Pickup();
    }



}
