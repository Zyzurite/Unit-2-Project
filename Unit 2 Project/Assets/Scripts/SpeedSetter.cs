using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedSetter : MonoBehaviour
{
    public float Playerspeed;
    public GameObject player;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) //applies only to objects tagged with “Player”
        {
            player.GetComponent<BallMovement>().speed = Playerspeed;
        }
    }
}
