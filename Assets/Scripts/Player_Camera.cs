using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Camera : MonoBehaviour
{
    // Camera will follow this game object
    GameObject player;

    // By default, camera will follow player
    bool follow_player = true;

    // Start is called before the first frame update
    void Start()
    {
        // Find game object with player tag
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (follow_player)
        {
            // Set camera to follows
            camera_follow();
        }
    }

    // Function which will simulate camera following player
    void camera_follow()
    {
        // Retrieve the current player position and set it as the new position
        Vector3 new_pos = new Vector3(player.transform.position.x, player.transform.position.y, this.transform.position.z);

        // Set the camera postion to the current player position
        this.transform.position = new_pos;
    }
}
