using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject prefab;
    public Transform tile;

    private void Awake()
    {
        tile = gameObject.transform;
    }
    public void SpawnObject(GameObject prefab)
    {
        Instantiate(prefab, tile.position, tile.rotation,tile);
        Event_Options.tileStage++;
    }
}
