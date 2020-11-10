
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public playerMovement movement; // A reference to our PlayerMovement script

    // Detect if we hit another object
    // collisionInfo - get info about the collision
    void OnCollisionEnter (Collision collisionInfo)
    {
        // Check if the object collide with a tag called  "Obsticle"
        if (collisionInfo.collider.tag == "Obstacle") 
        {
            movement.enabled = false; // Disable the player movement
            FindObjectOfType<GameManager>().EndGame();
            
        }
    }
}
