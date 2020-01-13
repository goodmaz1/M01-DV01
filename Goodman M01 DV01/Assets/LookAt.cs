
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform player; //player location
    public bool moving = false; //initializes ghost to staying still and just looking at the player
    public float speed = 10f; //how fast the ghost moves


    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player); //turn ghost to face player

        if (moving == true) //only makes the ghost move if you click the "moving" box
        {
            transform.position += transform.forward * speed * Time.deltaTime; //moves the ghost forward in the direction it's facing at 'speed'
        }
    }
}
