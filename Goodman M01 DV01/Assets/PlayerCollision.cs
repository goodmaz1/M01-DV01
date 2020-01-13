
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;


    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle") //if the player runs into an object (box) with the "obstacle" tag, 
        {
            movement.enabled = false; //Makes the game stop if you run into an obstacle
        }
    }
}
