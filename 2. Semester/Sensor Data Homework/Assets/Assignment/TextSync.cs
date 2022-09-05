using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSync : MonoBehaviour
{
    public TMPro.TMP_Text text;
    public SensorData sD;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(text && sD.checking == true)
        {
            text.text = "Acceleration " + Input.acceleration.ToString();
        }

    }
}
