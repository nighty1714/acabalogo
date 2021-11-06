using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedAI : MonoBehaviour
{
    GameObject target;
    void Start(){
        target = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update(){
            transform.LookAt(target.transform, Vector3.up);
    }
}
