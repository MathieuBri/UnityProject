using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeDeplacement : MonoBehaviour {

    
    public string sens;
	// Use this for initialization
	void Start ()
    {
        sens = "forward";
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Debug.Log(sens);
        if (sens == "forward")
        {
            transform.position += Vector3.forward * Time.deltaTime* Random.Range(10,20);
        }
        else if (sens == "back")
        {
            transform.position += Vector3.back * Time.deltaTime * Random.Range(10, 20);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Cube (6)")
        {
            sens = "back";
        }
        else if (collision.gameObject.name == "Cube (2)")
        {
            sens = "forward";
        }
    }
}
