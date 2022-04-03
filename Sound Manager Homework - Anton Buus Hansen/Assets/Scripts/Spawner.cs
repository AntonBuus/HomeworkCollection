using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    Rigidbody rb;

    public GameObject BonkDog;

    public Transform spawnPoint;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void SpawnBonkDog()
    {
        Instantiate(BonkDog, spawnPoint.position, Quaternion.identity);
    }
}
