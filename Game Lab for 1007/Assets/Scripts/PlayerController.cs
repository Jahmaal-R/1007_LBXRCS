using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D player_Rigidbody;

    //How fast the player can move
    public float moveSpeed = 12f;
    public Animator animator;

    //Knowing the player's position
    private Transform playerPosition;
    public Transform fakePlayer;

    public bool isFacingRight = true;

    void Start()
    {
        //Assigning the Rigidbody in script so I can use it
        player_Rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
    }

    void Flip ()
    {
        isFacingRight = !isFacingRight;

        if (!isFacingRight)
        {
            fakePlayer.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            fakePlayer.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        }

    void Move()
    {

        //Find input and add forces to the rigidboy so that my man can move :D

        if (Input.GetKey(KeyCode.W))
        {
            player_Rigidbody.AddForce(transform.up * moveSpeed);
            animator.SetBool("Not moving", false);
            animator.SetBool("Up", true);
        }
        else
        {
            animator.SetBool("Up", false);
        }

        if (Input.GetKey(KeyCode.D))
        {
            player_Rigidbody.AddForce(transform.right * moveSpeed);
            animator.SetBool("Not moving", false);
            animator.SetBool("Right", true);

            if (isFacingRight == false)
            {
                Flip();
            }

        }
        else
        {
            animator.SetBool("Right", false);
        }
        if (Input.GetKey(KeyCode.A))
        {
            player_Rigidbody.AddForce(-transform.right * moveSpeed);
            animator.SetBool("Not moving", false);
            animator.SetBool("Right", true);

            if (isFacingRight)
            {
                Flip();
            }
        }
        else
        {
            animator.SetBool("Left", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            player_Rigidbody.AddForce(-transform.up * moveSpeed);
            animator.SetBool("Not moving", false);
            animator.SetBool("Down", true);
        }
        else
        {
            animator.SetBool("Down", false);
        }

        if (!(animator.GetBool("Down") || animator.GetBool("Right") || animator.GetBool("Up")))
        {
            animator.SetBool("Not moving", true);
        }


     }

    }

         
