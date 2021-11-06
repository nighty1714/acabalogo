using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float mouseScrollDelta = 0;
    public float sensibility = 0.02f;
    float previousMouseScrollDelta = 0;

    private void Start(){
        previousMouseScrollDelta = Input.GetAxis("Mouse X");
    }
    // Update is called once per frame
    void Update()
    {
        mouseScrollDelta = Input.GetAxis("Mouse X");
        float delta = mouseScrollDelta - previousMouseScrollDelta;
        delta = delta*sensibility*Mathf.Rad2Deg;
        transform.Rotate(0, delta, 0);
    }
}
