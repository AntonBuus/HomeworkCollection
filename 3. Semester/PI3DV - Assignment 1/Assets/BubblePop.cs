using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubblePop : MonoBehaviour
{
    void OnTriggerEnter(Collider other) 
    {
        ScoreManager.inst.IncrementScore();
        Destroy(this.gameObject);
    }
}
