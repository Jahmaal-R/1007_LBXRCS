using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    
    //Getting the position of the sprite used
    public Transform Player;
    // Finding the gameobject we need to spawn 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        LookAtMouse();

    }

    void LookAtMouse()
    {
        //Getting the position where my mouse is on the screen 
        Vector3 mousePosition = Input.mousePosition;
        //Adding it to a easy to use variable, very cool
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        //Using the mousePosition to turn the sprite 
        Vector2 lookDirection = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
        transform.up = lookDirection;

    }

}
