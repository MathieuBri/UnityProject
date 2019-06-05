using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saver : MonoBehaviour
{
    public string configFilePath;
    public Volume volume = new Volume();

    void Start()
    {
        configFilePath = Application.streamingAssetsPath + "/config.json";
    }

    void OnApplicationQuit()
    {
        SaveConfiguration();
    }

    private void SaveConfiguration()
    {

    }
}

[System.Serializable]
public class Volume
{
    public float level;
}