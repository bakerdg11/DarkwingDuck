using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{

    public enum PickupType
    {
        Life,
        Score,
    }


    [SerializeField] PickupType currentCollectible;
    [SerializeField] float timeToDestroy = 0;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerController pc = collision.GetComponent<PlayerController>();
            /*switch (currentCollectible)
            {
                case PickupType.Life:
                    pc.lives++;
                    break;
                case PickupType.Score:
                    pc.score++;
                    break;
            }*/
            Destroy(gameObject, timeToDestroy);
        }
    }



}