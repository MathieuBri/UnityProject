using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    private string start;
    public List<Collider> colliders;

    private void OnCollisionEnter(Collision collision)
    {
        if (colliders.Find(x => x.name == collision.gameObject.name))
        {
            AudioSource deathSound = gameObject.GetComponent<AudioSource>();
            deathSound.volume = PlayerPrefs.GetFloat("volume");
            deathSound.Play();
            SceneManager.LoadScene("Scenes/LostScreen");
        }
    }
}
