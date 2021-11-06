using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCam : MonoBehaviour
{
    public Camera overheadCamera;
    void Start()
    {
        overheadCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("MainCamera") == null){
            overheadCamera.enabled = true;
        }
    }
}

