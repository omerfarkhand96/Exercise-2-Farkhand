using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedestrian : MonoBehaviour
{
    public float speed = 2.0f;

    private Vector3 pedPos;
    private Vector3 currPos;
    Vector3 pedMove;

    // Start is called before the first frame update
    void Start()
    {
        pedPos = transform.position;
        currPos = pedPos;
    }

    // Update is called once per frame
    void Update()
    {
        pedMove = transform.TransformDirection(0, 0, 1);

        if (currPos.x < 0f)
        {
            pedPos += pedMove * speed * Time.deltaTime;
            transform.position = pedPos;
        }
        else if (currPos.x > 0f)
        {
            pedPos -= pedMove * speed * Time.deltaTime;
            transform.position = pedPos;
        }
    }

    // Triggers when the Car enters the collider
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Side")
        {
            speed *= -1;
        }
    }
}
