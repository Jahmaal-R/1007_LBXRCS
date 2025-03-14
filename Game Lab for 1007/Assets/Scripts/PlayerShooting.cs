using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public Transform Player;
    public GameObject bullet;
    public float pistolFireRate = 1f;
    public float rifleFireRate = .2f;
    public float shotgunFireRate = 1f;
    public float timeToFire = 1;
    public int gunMode = 0;
    public bool hasPowerup = false;
    public Collider playerCollider;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            gunMode = 0;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            gunMode = 1;
        }
        if (hasPowerup && Input.GetKey(KeyCode.Alpha3))
        {
            gunMode = 2;
        }

        Shoot();
    }


    void Pistol()
    {
        if (timeToFire >= pistolFireRate)
        {
            if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
            {
                timeToFire = 0;
                Instantiate(bullet, Player.position, Player.rotation);
            }
        }
   }

    void Rifle()
    {
        if (timeToFire >= rifleFireRate)
        {
            if (Input.GetMouseButton(0) || Input.GetKey(KeyCode.Space))
            {
                timeToFire = 0;
                Instantiate(bullet, Player.position, Player.rotation);
            }
        }
    }

    void Shotgun()
    {
        Quaternion bulletRotation = Player.rotation * Quaternion.Euler(0f, 0f, Random.Range(-30, 30));
        if (timeToFire >= shotgunFireRate)
        {

            if (Input.GetMouseButton(0) || Input.GetKey(KeyCode.Space))
            {
                timeToFire = 0;
               Instantiate(bullet, Player.position, Player.rotation * Quaternion.Euler(0f, 0f, Random.Range(-20, 20)));
               Instantiate(bullet, Player.position, Player.rotation * Quaternion.Euler(0f, 0f, Random.Range(-20, 20)));
               Instantiate(bullet, Player.position, Player.rotation * Quaternion.Euler(0f, 0f, Random.Range(-20, 20)));
               Instantiate(bullet, Player.position, Player.rotation * Quaternion.Euler(0f, 0f, Random.Range(-20, 20)));
               Instantiate(bullet, Player.position, Player.rotation * Quaternion.Euler(0f, 0f, Random.Range(-20, 20)));
               Instantiate(bullet, Player.position, Player.rotation * Quaternion.Euler(0f, 0f, Random.Range(-20, 20)));
            }
        }
    }



    void Shoot()
    {
        if (gunMode == 0)
            {
            Pistol();
            }
        if (gunMode == 1)
        {
            Rifle();
         }
        if (gunMode == 2)
        {
            Shotgun();
        }
            timeToFire += 4 * Time.deltaTime;
     
    }

    public void Powerup(int type)
    {
        hasPowerup = true;
        gunMode = type;
    }
}
