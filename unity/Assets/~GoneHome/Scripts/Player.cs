using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
[] - Brackets 
{} - Braces
() - Parenthesis 

Hot kets:
- Clean Codes: CTRL + K + D 
- Fold code: CTRL + M + O 
- unfold Code: CTRL + M + P 
*/


public class Player : MonoBehaviour
{
    public string message = "Hello World!";
    public Rigidbody rigid;

    float speed = 5;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rigid.AddForce(Vector3.forward * speed);
        }


    }
}
