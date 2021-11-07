using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public Camera uiCamera;
    public Camera playerCamera;
    public Canvas WinnerText;

    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.layer == 3){
            playerCamera.enabled = false;
            uiCamera.enabled = true;
            WinnerText.enabled = true;
        }
    }
}
