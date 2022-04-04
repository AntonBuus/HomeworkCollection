using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    Rigidbody rb;

    public GameObject ObjectToSpawn;

    public Transform spawnPoint;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void SpawnObject()
    {
        Instantiate(ObjectToSpawn, spawnPoint.position, Quaternion.identity);
        //Destroy(this.gameObject);
    }
}
