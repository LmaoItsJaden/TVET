using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 20f; //units to travel per second 
    public float rotationspeed = 360f; // amount of rotation per second 

    private Rigidbody2D rigid; // reference to attached RigidBody2dD

    // Use this for initialization
    void Start()
    {
        // Tried to add force in the transform's up direction via speed
        // NOTE: It gets this from the GameObject this script is attached to
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
