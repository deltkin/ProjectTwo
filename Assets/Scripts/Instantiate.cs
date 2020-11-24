using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject prefab;
    public Transform spawnPoint;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            Instantiate(prefab, spawnPoint.position, Quaternion.identity);
        }
    }
}
