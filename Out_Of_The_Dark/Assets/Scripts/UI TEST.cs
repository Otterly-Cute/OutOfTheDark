using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UITEST : MonoBehaviour
{
    public GameObject canvas;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {  canvas.SetActive(false); }
    }
}
