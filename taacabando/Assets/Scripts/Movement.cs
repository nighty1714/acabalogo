using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float velocity = 0.1f;
    private bool isColiding = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!isColiding){
            if(Input.GetKey(KeyCode.W)  || Input.GetKey(KeyCode.UpArrow)){
                gameObject.transform.position += gameObject.transform.forward*velocity;
            }
            if(Input.GetKey(KeyCode.S)  || Input.GetKey(KeyCode.DownArrow)){
                gameObject.transform.position += gameObject.transform.forward*-1*velocity;
            }
            if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
                gameObject.transform.position += gameObject.transform.right*-1*velocity;
            }
            if(Input.GetKey(KeyCode.D)  || Input.GetKey(KeyCode.RightArrow)){
                gameObject.transform.position += gameObject.transform.right*velocity;
            }
        }
    }
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.layer == 7){
            isColiding = true;
        }
        // if(Input.GetKey(KeyCode.W)  || Input.GetKey(KeyCode.UpArrow)){
        //     //gameObject.transform.position += gameObject.transform.forward*-2f*velocity;
        // }
        // if(Input.GetKey(KeyCode.S)  || Input.GetKey(KeyCode.DownArrow)){
        //     //gameObject.transform.position += gameObject.transform.forward*2f*velocity;
        // }
        // if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
        //     //gameObject.transform.position += gameObject.transform.right*2f*velocity;
        // }
        // if(Input.GetKey(KeyCode.D)  || Input.GetKey(KeyCode.RightArrow)){
        //     //gameObject.transform.position += gameObject.transform.right*-2f*velocity;
        // }
    }
    private void OnCollisionExit(Collision other) {
        isColiding = false;
    }
}
