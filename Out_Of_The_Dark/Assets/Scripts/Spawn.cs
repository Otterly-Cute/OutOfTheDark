using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject prefab;

    private void Awake()
    {
        
    }
    public void SpawnObject(GameObject gameObject)
    {
        Instantiate(prefab, gameObject.transform.root);
    }

}
