using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public Canvas WinnerText;
    void Start()
    {
        WinnerText.enabled = false;
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.layer != 0){
            WinnerText.enabled = true;
            collision.gameObject.layer = 0;
        }
    }
}
