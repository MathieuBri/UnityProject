using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour {

    public GameObject cameraOne;
    public GameObject cameraTwo;

    AudioListener cameraOneAudioLis;
    AudioListener cameraTwoAudioLis;

    // Use this for initialization
    void Start () {
        //Get Camera Listeners
        cameraOneAudioLis = cameraOne.GetComponent<AudioListener>();
        cameraTwoAudioLis = cameraTwo.GetComponent<AudioListener>();

        //Camera Position Set
        cameraPostionChange(PlayerPrefs.GetInt("CameraPostion"));
		
	}
	
	// Update is called once per frame
	void Update () {
        //Change Camera Keyboard
        swichtCamera();
	}

    public void cameraPositionM()
    {
        cameraChangeCounter();
    }
    void swichtCamera()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            cameraChangeCounter();
        }
    }

    void cameraChangeCounter()
    {
        int cameraPostionCounter = PlayerPrefs.GetInt("CameraPostion");
        cameraPostionCounter++;
        cameraPostionChange(cameraPostionCounter);

    }

    void cameraPostionChange(int camPosition)
    {
        if(camPosition > 1)
        {
            camPosition = 0;
        }

        PlayerPrefs.SetInt("CameraPostion", camPosition);

        if(camPosition == 0)
        {
            cameraOne.SetActive(true);
            cameraOneAudioLis.enabled = true;

            cameraTwoAudioLis.enabled = false;
            cameraTwo.SetActive(false);
        }

        if(camPosition == 1)
        {
            cameraTwo.SetActive(true);
            cameraTwoAudioLis.enabled = true;

            cameraOneAudioLis.enabled = true;
            cameraOne.SetActive(false);

        }
    }

}
