using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float speed = 2.0f;

    private Vector3 carPos;
    private Vector3 currPos;
    Vector3 vehicleMove;

    // Start is called before the first frame update
    void Start()
    {
        carPos = transform.position;
        currPos = carPos; 
    }

    // Update is called once per frame
    void Update()
    {
        vehicleMove = transform.TransformDirection(0, 0, 1);
        if (currPos.x < 0f) {
            carPos += vehicleMove * speed * Time.deltaTime;
            transform.position = carPos;
        }  else if(currPos.x > 0f) {
            carPos -= vehicleMove * speed * Time.deltaTime;
            transform.position = carPos;
        }
    }

    // Triggers
    void OnTriggerExit(Collider other)
    {
 
        if(other.tag == "walls")
        {
            speed *= -1;
        }
    }
}
