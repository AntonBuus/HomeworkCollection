using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    Rigidbody rb;

    public GameObject bottle;

    public Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        //SpawnBottle();

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnBottle();
        }
        //if (Input)
    }

    void SpawnBottle()
    {
        Instantiate(bottle, spawnPoint.position, Quaternion.identity);

            
        }
    

}

