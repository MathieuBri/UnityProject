using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Lava_distort" || collision.gameObject.name == "Sphere" || collision.gameObject.name == "Cube (12)" || collision.gameObject.name == "Cube (13)"
            || collision.gameObject.name == "Cube (14)" || collision.gameObject.name == "Cube (15)" || collision.gameObject.name == "Cube (16)" || collision.gameObject.name == "Cube (17)"
            || collision.gameObject.name == "Cube (18)" || collision.gameObject.name == "Cube (19)" || collision.gameObject.name == "Cube (20)" || collision.gameObject.name == "Cube (21)"
            || collision.gameObject.name == "Cube (22)" || collision.gameObject.name == "Cube (23)" || collision.gameObject.name == "Plane (15)" || collision.gameObject.name == "FallenCube"
            || collision.gameObject.name == "FallenCube (1)" || collision.gameObject.name == "FallenCube (2)" || collision.gameObject.name == "FallenCube (3)")
        {

        }
        


    }
}
