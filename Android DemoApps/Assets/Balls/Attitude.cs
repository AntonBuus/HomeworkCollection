using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Attitude : MonoBehaviour
{

    private void Start() {
        if (SystemInfo.supportsGyroscope)
        {
            Input.gyro.enabled = true;
        }
    }
    

    private void Update() {
        
        if (SystemInfo.supportsGyroscope)
        {
            transform.rotation = GyroAxisConvert(Input.gyro.attitude);
        }
    }

    private Quaternion GyroAxisConvert(Quaternion q)
    {
        return new Quaternion(q.x, q.z, q.y, -q.w);
    }
}
