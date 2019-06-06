using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LesBouBoules : MonoBehaviour {

    public Transform[] boule;
    public Transform[] boule1;
    public Transform[] boule2;
    public Transform[] boule3;
    public Transform[] boule4;
    private string start;
    public int vitesseBoules;

    private float timer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (start == "ok")
        {
            timer += Time.deltaTime;
            foreach(Transform boulee in boule)
            {
                boulee.transform.position += Vector3.back * Time.deltaTime * vitesseBoules;
                boulee.transform.Rotate(Vector3.left * Time.deltaTime * vitesseBoules);
            }
            
            if (timer > 2)
            {
                foreach (Transform boulee in boule1)
                {
                    boulee.transform.position += Vector3.back * Time.deltaTime * vitesseBoules;
                    boulee.transform.Rotate(Vector3.left * Time.deltaTime * vitesseBoules);
                }
            }
            if (timer > 4)
            {
                foreach (Transform boulee in boule2)
                {
                    boulee.transform.position += Vector3.back * Time.deltaTime * vitesseBoules;
                    boulee.transform.Rotate(Vector3.left * Time.deltaTime * vitesseBoules);
                }
            }
            if (timer > 6)
            {
                foreach (Transform boulee in boule3)
                {
                    boulee.transform.position += Vector3.back * Time.deltaTime * vitesseBoules;
                    boulee.transform.Rotate(Vector3.left * Time.deltaTime * vitesseBoules);
                }
            }
            if (timer > 8)
            {
                foreach (Transform boulee in boule4)
                {
                    boulee.transform.position += Vector3.back * Time.deltaTime * vitesseBoules;
                    boulee.transform.Rotate(Vector3.left * Time.deltaTime * vitesseBoules);
                }
            }
        }
		
	}
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Declencheur")
        {
            start = "ok";
        }
       



    }
}
