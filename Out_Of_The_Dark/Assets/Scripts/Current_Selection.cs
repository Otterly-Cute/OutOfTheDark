using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Current_Selection", menuName = "ScriptableObjects/current")]
public class Current_Selection : ScriptableObject
{

    public GameObject currentSelected;

    public void SetCurrent(GameObject tmp)
    { 
        currentSelected = tmp; 
    }
    
}
