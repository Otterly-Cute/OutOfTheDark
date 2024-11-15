using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Handling : MonoBehaviour
{
    
    public GameObject menu;

    public void EnableCanvas(GameObject menu)
    {
        menu.SetActive(true);
    }

    public void DisableCanvas(GameObject menu)
    {
        menu.SetActive(false);
    }
    
    
}
