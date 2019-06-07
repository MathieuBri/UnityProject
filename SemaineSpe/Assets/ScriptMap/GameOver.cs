using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    private string start;
    public List<Collider> colliders;
    public BoxCollider chest;

    private AudioSource[] sounds;
    private void Start()
    {
        sounds = GetComponents<AudioSource>();
        sounds[0].volume = PlayerPrefs.GetFloat("volume") / 100;
        sounds[1].volume = PlayerPrefs.GetFloat("volume") / 100;
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
