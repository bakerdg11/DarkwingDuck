using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    SpriteRenderer sr;

    public Vector2 initialVelocity;
    public Transform spawnPointLeft;
    public Transform spawnPointRight;
    public Projectile projectilePrefab;


    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

    }



    public void Fire()
    {
        if (!sr.flipX)
        {
            Projectile currentProjectile = Instantiate(projectilePrefab, spawnPointRight.position, spawnPointRight.rotation);
            currentProjectile.intialVelocity = initialVelocity;
        }
        else
        {
            Projectile currentProjectile = Instantiate(projectilePrefab, spawnPointLeft.position, spawnPointLeft.rotation);
            currentProjectile.intialVelocity = initialVelocity;
        }



    }


}
