using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public int powerUpID = 2;
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col);
        if (col.gameObject.tag == "Player")
        {
            PlayerShooting playershoot = col.transform.GetComponent<PlayerShooting>();

            if (playershoot != null)
            {
                playershoot.Powerup(powerUpID);
                Destroy(gameObject);
            }
            else
            {
                Debug.LogWarning("PlayerShooting component not found on " + col.gameObject.name);
            }
        }
    }
}
