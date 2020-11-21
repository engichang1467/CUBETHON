/**
 playerMovement.cs

 This file deals with the movement of the player
 --
*/

using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Refer to rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public Vector3 jump = new Vector3(0.0f, 2.0f, 0.0f);
    public float jumpForce = 3.0f;

    // Use FixedUpdate function to mess with physics
    void FixedUpdate()
    {
        // Add forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); 

        if (Input.GetKey("d"))
        {
            // Add a force to the right
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            // Add a force to the left
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Add force to jump
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
