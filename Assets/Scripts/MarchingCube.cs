using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarchingCube : MonoBehaviour
{
    private List<Vector3> cubePoints = new List<Vector3>
    {
        new Vector3(0, 0, 0),
        new Vector3(10, 0, 0),
        new Vector3(10, 10, 0),
        new Vector3(0, 10, 0),
        new Vector3(0, 0, 10),
        new Vector3(10, 0, 10),
        new Vector3(10, 10, 10),
        new Vector3(0, 10, 10),
    };

    [SerializeField] 



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
