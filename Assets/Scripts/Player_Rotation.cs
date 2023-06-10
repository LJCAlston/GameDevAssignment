using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Rotation : MonoBehaviour
{
    // Stores mouse position
    Vector3 mouse_position;

    // Camera object
    Camera cam;

    // Player rigid body
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        // Get player rigid body
        rb = this.GetComponent<Rigidbody2D>();

        // Retrieve main camera
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate to camera
        rotate_to_camera();
    }

    // Function which rotates the rigid body towards camera
    void rotate_to_camera()
    {
        // Calculate current mouse position
        mouse_position = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z - cam.transform.position.z));

        // Transform the player rigid body using euler angles (to prevent gimbal lock)
        rb.transform.eulerAngles = new Vector3(0, 0, Mathf.Atan2((mouse_position.y - transform.position.y),(mouse_position.x - transform.position.x)) * Mathf.Rad2Deg);
    }
}
