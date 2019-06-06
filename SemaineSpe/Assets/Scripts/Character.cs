using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{
    public BoxCollider chestCollider;
    public static List<TextMeshProUGUI> level1;

    private float timer;
	void Update ()
    {
        timer += Time.deltaTime;
	}
    private void OnCollisionEnter(Collision collision)
    {
        // collision with chest
        if (collision.collider.name == chestCollider.name)
        {
            //SceneManager.SetActiveScene(SceneManager.GetSceneByName("Scenes/menu"));
            SceneManager.LoadScene("Scenes/menu");
            GameObject.Find("Level1FirstTime").GetComponent<TextMeshProUGUI>().text = timer.ToString();
            // WIN
        }
    }
}
