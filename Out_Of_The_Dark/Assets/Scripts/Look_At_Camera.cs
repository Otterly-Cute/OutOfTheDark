using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look_At_Camera : MonoBehaviour
{
    //https://www.youtube.com/watch?v=NLi0gazYD90

    [SerializeField] GameObject _object;


    void Start()
    {
        
    }

   
    void Update()
    {
        transform.rotation = Quaternion.LookRotation(transform.position - _object.transform.position);
    }
}
