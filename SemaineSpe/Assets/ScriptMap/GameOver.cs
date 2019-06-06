using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    private string start;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (start == "ok")
        {
            Debug.Log("WOWOWOW");
            SceneManager.LoadScene("Scenes/LostScreen");
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "PlaneLave" || collision.gameObject.name == "Sphere" || collision.gameObject.name == "Cube (12)" || collision.gameObject.name == "Cube (13)"
            || collision.gameObject.name == "Cube (14)" || collision.gameObject.name == "Cube (15)" || collision.gameObject.name == "Cube (16)" || collision.gameObject.name == "Cube (17)"
            || collision.gameObject.name == "Cube (18)" || collision.gameObject.name == "Cube (19)" || collision.gameObject.name == "Cube (20)" || collision.gameObject.name == "Cube (21)"
            || collision.gameObject.name == "Cube (22)" || collision.gameObject.name == "Cube (23)" || collision.gameObject.name == "Plane (15)" || collision.gameObject.name == "FallenCube"
            || collision.gameObject.name == "FallenCube (1)" || collision.gameObject.name == "FallenCube (2)" || collision.gameObject.name == "FallenCube (3)" || collision.gameObject.name == "PlaneLave(1)"
            || collision.gameObject.name == "Bouboule" || collision.gameObject.name == "Bouboule (1)" || collision.gameObject.name == "Bouboule (2)"
            || collision.gameObject.name == "Bouboule (3)" || collision.gameObject.name == "Bouboule (4)" || collision.gameObject.name == "Bouboule (5)" || collision.gameObject.name == "Bouboule (6)"
            || collision.gameObject.name == "Bouboule (7)" || collision.gameObject.name == "Bouboule (8)" || collision.gameObject.name == "Bouboule (9)"
            || collision.gameObject.name == "Bouboule (10)" || collision.gameObject.name == "Bouboule (11)" || collision.gameObject.name == "Bouboule (12)"
            || collision.gameObject.name == "Bouboule (13)" || collision.gameObject.name == "Bouboule (14)" || collision.gameObject.name == "Bouboule (15)" || collision.gameObject.name == "Bouboule (16)"
            || collision.gameObject.name == "Bouboule (17)" || collision.gameObject.name == "Bouboule (18)" || collision.gameObject.name == "Bouboule (19)"
            || collision.gameObject.name == "Bouboule (20)" || collision.gameObject.name == "Bouboule (21)" || collision.gameObject.name == "Bouboule (22)"
            || collision.gameObject.name == "Bouboule (23)" || collision.gameObject.name == "Bouboule (24)" || collision.gameObject.name == "Bouboule (25)" || collision.gameObject.name == "Bouboule (26)"
            || collision.gameObject.name == "Bouboule (27)" || collision.gameObject.name == "Bouboule (28)" || collision.gameObject.name == "Bouboule (29)"
            || collision.gameObject.name == "Bouboule (30)" || collision.gameObject.name == "Bouboule (31)" || collision.gameObject.name == "Bouboule (32)"
            || collision.gameObject.name == "Bouboule (33)" || collision.gameObject.name == "Bouboule (34)" || collision.gameObject.name == "Bouboule (35)" || collision.gameObject.name == "Bouboule (36)"
            || collision.gameObject.name == "Bouboule (37)" || collision.gameObject.name == "Bouboule (38)" || collision.gameObject.name == "Bouboule (39)" || collision.gameObject.name == "Bouboule (40)"
            || collision.gameObject.name == "Bouboule (41)") 
        {
            start = "ok";
        }
        


    }
}
