using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCam : MonoBehaviour
{
    public Camera deathCamera;
    public Camera playerCamera;
    void Start(){
        deathCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerCamera.gameObject.activeInHierarchy == false){
            deathCamera.enabled = true;
        }
    }
}

