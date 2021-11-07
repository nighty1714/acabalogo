using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAI : MonoBehaviour
{
    GameObject target;
    public float velocity = 0.01f;
    void Start(){
        target = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update(){
        Vector3 step = target.transform.position - transform.position;
        transform.position += step * velocity;
    }

    private void OnCollisionEnter(Collision collision){
        //senao for uma parede, inimigo desativa o objeto(player)
        if(collision.gameObject.layer == 3){
            collision.gameObject.SetActive(false);     
        }
    }
}
