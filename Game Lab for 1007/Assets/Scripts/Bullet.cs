using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D b_Rigidbody;
    public float timeAlive = 0f;
    private float timeForDeath = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        b_Rigidbody.velocity = transform.up * speed;

        timeAlive += 1 * Time.deltaTime;

        if (timeForDeath < timeAlive)
        {
            Destroy(gameObject);
        }
    }

}
