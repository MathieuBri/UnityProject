using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaFloor : MonoBehaviour
{
    public Transform cube;
    public float vitesseCubes;
    private string start;
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(sens);
        
        if (start == "ok")
        {
            cube.transform.position += Vector3.back * Time.deltaTime * vitesseCubes;
        }
        
        
        
        
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Plane")
        {
            start = "ok";
        }
    }
}
