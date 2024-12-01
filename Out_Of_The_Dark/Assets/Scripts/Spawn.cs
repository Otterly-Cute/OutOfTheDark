using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject prefab;
    GameObject selectedTile;
    public Transform tile;

    private void Awake()
    {
        tile = gameObject.transform;
    }
    public void SpawnObject(GameObject prefab)
    {
        Instantiate(prefab, tile.position, tile.rotation,tile);
        selectedTile.Event_Options.tileStage++;
        Debug.Log(Event_Options.tileStage);
    }
}
