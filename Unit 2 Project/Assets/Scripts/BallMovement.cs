using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    public float speed = 2;
    private Rigidbody rb;

    Vector3 velocity;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        PlayerMover();
    }

    void PlayerMover()
    {
        // Turn player based on mouse movement
        
        // Move player based on keyboard presses

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(x, 0f, 0f);
        rb.AddForce(move * speed);
    }

}
