using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallenCube : MonoBehaviour {

    public Transform cube;
    public Transform cube1;
    public Transform cube2;
    public Transform cube3;
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
            cube.transform.position += Vector3.down * Time.deltaTime * vitesseCubes;
        }
        else if (start == "okk")
        {
            cube1.transform.position += Vector3.down * Time.deltaTime * vitesseCubes;
        }
        else if (start == "okkk")
        {
            cube2.transform.position += Vector3.down * Time.deltaTime * vitesseCubes;
        }
        else if (start == "okkkk")
        {
            cube3.transform.position += Vector3.down * Time.deltaTime * vitesseCubes;
        }






    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "FallenCube1")
        {
            start = "ok";
        }
        else if (collision.gameObject.name == "FallenCube1 (1)")
        {
            start = "okk";
        }
        else if (collision.gameObject.name == "FallenCube1 (2)")
        {
            start = "okkk";
        }
        else if (collision.gameObject.name == "FallenCube1 (3)")
        {
            start = "okkkk";
        }



    }

    
}
