using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomBoxCheck : MonoBehaviour
{
    public GameObject boomBox;
    public bool isActive;

    public void CheckBox()
    {
        if(isActive == true)
        {
            boomBox.SetActive (true);
        }
        else
        {
            boomBox.SetActive (false);
        }
    }
}
