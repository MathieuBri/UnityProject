﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallenCube : MonoBehaviour {

    public Transform cube;
    public Transform cube1;
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
        





    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "FallenCube1")
        {
            start = "ok";
        }

       
       
    }

    
}