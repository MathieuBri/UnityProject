using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    private string start;
    public List<Collider> colliders;
    public BoxCollider chest;

    private AudioSource[] sounds;
    private float timer;
    private void Start()
    {
        sounds = GetComponents<AudioSource>();
        sounds[0].volume = PlayerPrefs.GetFloat("volume") / 100;
        sounds[1].volume = PlayerPrefs.GetFloat("volume") / 100;
    }

    void Update()
    {
        timer += Time.deltaTime;
        GameObject.Find("Time Value").GetComponent<Text>().text = System.Math.Round(timer, 1).ToString();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (colliders.Find(x => x.name == collision.gameObject.name))
        {
            sounds[0].Stop();
            sounds[1].Play();
            SceneManager.LoadScene("Scenes/LostScreen");
        }
        else if (collision.gameObject.name == chest.gameObject.name)
        {
            SceneManager.LoadScene("Scenes/WinScreen");
        }
    }
}
