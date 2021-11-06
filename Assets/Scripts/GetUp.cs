using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetUp : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = gameObject.transform.rotation.eulerAngles.x;
        float y = gameObject.transform.rotation.eulerAngles.z;
        if(x+y > 90){
            gameObject.transform.rotation = Quaternion.Euler(0, gameObject.transform.rotation.eulerAngles.y, 0);
        }
        
    }
}
