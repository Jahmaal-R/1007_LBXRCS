using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D player_Rigidbody;


    public float moveSpeed = 8f;

    private Transform playerPosition;

    // Start is called before the first frame update
    void Start()
    {
        player_Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

 

    void Move()
    {

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
         
