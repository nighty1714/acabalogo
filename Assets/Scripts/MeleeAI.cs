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
        if(Random.Range(0,10) < 9){
            transform.position += step * velocity;
        }else{
            transform.position += step * 5 * velocity;
        }
    }

    private void OnCollisionEnter(Collision collision){
        //senao for uma parede, o tiro destroi o objeto
        if(collision.gameObject.layer == 3){
            collision.gameObject.SetActive(false);     
        }
    }
}
