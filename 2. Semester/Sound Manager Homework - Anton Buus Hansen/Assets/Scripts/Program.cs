using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Program : MonoBehaviour
{
    public int tal = 1;
    

    void Start()
    {
        AendreTal(ref tal);

        Debug.Log(tal);
        //Debug.Log("nyt tal er "+ nytTal);
    }

    public void AendreTal(ref int nytTal)
    {
        nytTal = 5;
    }

    // public void ÆndreTal(float nytTal)
    // {
    //     nytTal = 5.5;
    // }
}
