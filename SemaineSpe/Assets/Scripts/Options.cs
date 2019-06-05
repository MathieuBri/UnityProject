using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    private const float DefaultVolumeLevel = 50.0f;
    private Slider VolumeBar;
    void Start()
    {
        VolumeBar = GameObject.Find("VolumeBar").GetComponent<Slider>();

        VolumeBar.value = PlayerPrefs.HasKey("volume") ? PlayerPrefs.GetFloat("volume") : DefaultVolumeLevel;
    }

    public void UpdateVolume(Slider volumeBar)
    {
        PlayerPrefs.SetFloat("volume", volumeBar.value);
    }
    public void BackButton()
    {
        PlayerPrefs.Save();
    }
}
