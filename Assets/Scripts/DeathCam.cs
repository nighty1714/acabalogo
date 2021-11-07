using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCam : MonoBehaviour
{
    public Camera deathCamera;
    public Camera playerCamera;
    public Canvas GameOverText;
    void Start(){
        deathCamera.enabled = false;
        GameOverText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerCamera.gameObject.activeInHierarchy == false){
            deathCamera.enabled = true;
            GameOverText.enabled = true;
        }
    }
}

