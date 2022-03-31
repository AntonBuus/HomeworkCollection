using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SensorData : MonoBehaviour
{
    string filename = "";
    
    [System.Serializable]
    public class Data
    {
        public float x;
        public float y;
        public float z;
    }
    [System.Serializable]
    public class DataList
    {
        public Data[] data;
    }

    public DataList myDataList = new DataList();
    public bool checking = false;
    //private int dataLimit = 1000;


    void Start()
    {
        filename = Application.dataPath + "/testCSV.csv";
        TextWriter tw = new StreamWriter(filename, false);
        tw.WriteLine("x;y;z");
        tw.Close();
    }


    void Update()
    {
       if (checking == true)
        {
            WriteCSV();

        }

    }

     public void Click()
    {
        if (checking == true)
        {
            checking = false;
        }
        else if (checking == false)
        {
            checking = true;

        }
    }
    public void WriteCSV()
    {
        if(myDataList.data.Length > 0)
        {
            TextWriter tw = new StreamWriter (filename, true);
            tw.Close();

            tw = new StreamWriter(filename, true);



            for(int i = 0; i < myDataList.data.Length; i++)
            {
                myDataList.data[i].x = Input.acceleration.x;
                myDataList.data[i].y = Input.acceleration.y;
                myDataList.data[i].z = Input.acceleration.z;
                tw.WriteLine(myDataList.data[i].x + ";" + myDataList.data[i].y + ";" + myDataList.data[i].z);
            }
            tw.Close();
            Debug.Log("Checking");
        }

    }
}
