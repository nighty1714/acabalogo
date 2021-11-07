using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoDeTiro : MonoBehaviour
{
    public float lifeTime = 3;
    public float velocity = 0.05f;
    void Update()
    {
        lifeTime -= Time.deltaTime;
        if(lifeTime <=0 ){
            Destroy(gameObject);
        }
        gameObject.transform.position += gameObject.transform.forward*velocity;
    }

    private void OnCollisionEnter(Collision collision){
        //senao for uma parede, o tiro destroi o objeto
        if(collision.gameObject.layer == 6){
            Destroy(collision.gameObject);        
        }
        //depois de acertar alguma coisa, o tiro desaparece
        Destroy(gameObject);
    }
}
