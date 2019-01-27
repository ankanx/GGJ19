using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnclouds : MonoBehaviour
{

    public List<GameObject> prefabs = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCloud", 50.0f, 50f);
    }

    public void SpawnCloud()
    {
        GameObject prefab = prefabs[Random.Range(0, prefabs.Count)]; 
        Instantiate(prefab, this.transform);
    }
}
