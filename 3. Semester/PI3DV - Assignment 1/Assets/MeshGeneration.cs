using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// full credit to brackeys
[RequireComponent(typeof(MeshFilter))]
public class MeshGeneration : MonoBehaviour
{
    Mesh mesh;

    // public int x;
    // public int z;

    Vector3[] vertices;
    int[] triangles;

    void Start()
    {
        mesh = new Mesh();

        GetComponent<MeshFilter>().mesh = mesh;

        
        // add your code here
        // for(x=0;x<3; x++)
        //     for(z=0;z<3; z++)
        //         vtx[x,z]=v3(x,0,z)
        CreateShape();
        UpdateShape();

        
        
        
    }

    void CreateShape()
    {
        vertices = new Vector3[]
        {
            new Vector3 (0,0,0),
            new Vector3 (0,0,1),
            new Vector3 (1,0,0),
            new Vector3 (1,0,1)
        };

        triangles = new int[]
        {
            0,1,2,
            1,3,2
        };
    }

    void UpdateShape()
    {
        mesh.Clear();

        mesh.vertices = vertices;
        mesh.triangles = triangles;

        mesh.RecalculateNormals(); //makes light shine on mesh properly
    }
}