using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    // Is player moving?
    public bool moving = false;
    // Default speed of the player
    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Checks for user input for movement
        movement();
    }

    void movement()
    {
        // User wants to move upwards
        if (Input.GetKey(KeyCode.W))
        {
            // transform player model upwards
            transform.Translate(Vector3.up * speed * Time.deltaTime, Space.World);
            moving = true;
        }
        // User wants to move left
        if (Input.GetKey(KeyCode.A))
        {
            // Transform player model to the left
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
            moving = true;
        }
        // User wants to move downwards
        if (Input.GetKey(KeyCode.S))
        {
            // Transform player model downwards
            transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
            moving = true;
        }
        // User wants to move right
        if (Input.GetKey(KeyCode.D))
        {
            // Transform player model to the right
            transform.Translate(Vector3.right * speed * Time.deltaTime, Space.World);
            moving = true;
        }

        // If WASD keys are ALL not pressed
        if (Input.GetKey(KeyCode.W) != true && Input.GetKey(KeyCode.A) != true && Input.GetKey(KeyCode.S) != true && Input.GetKey(KeyCode.D) != true)
        {
            // Set moving to false
            moving = false;
        }
    }
}
