using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D player_Rigidbody;

    //How fast the player can move
    public float moveSpeed = 12f;

    //Knowing the player's position
    private Transform playerPosition;

    void Start()
    {
        //Assigning the Rigidbody in script so I can use it
        player_Rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
    }

 

    void Move()
    {

        //Find input and add forces to the rigidboy so that my man can move :D

        if (Input.GetKey(KeyCode.W))
        {
            player_Rigidbody.AddForce(transform.up * moveSpeed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            player_Rigidbody.AddForce(transform.right * moveSpeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            player_Rigidbody.AddForce(-transform.right * moveSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            player_Rigidbody.AddForce(-transform.up * moveSpeed);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {

        }

    }

}
         
