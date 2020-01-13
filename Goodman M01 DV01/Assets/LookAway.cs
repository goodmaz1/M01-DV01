
using UnityEngine;

public class LookAway : MonoBehaviour
{
    public Transform player; //player location
    public Vector3 away; //vector in the opposite direction of looking at the player
    public bool moving = false; //initializes ghost to staying still and just looking at the player
    public float speed = 10f; //how fast the ghost moves

    // Update is called once per frame
    void Update()
    {
        Vector3 away = transform.position - player.transform.position; //creates a vector from the ghost to the player, but away from the player
        transform.rotation = Quaternion.LookRotation(away); //actually turns the ghost in the direction away from the player

        if (moving == true) //only makes the ghost move if you click the "moving" box
        {
            transform.position += transform.forward * speed * Time.deltaTime; //moves the ghost forward in the direction it's facing at 'speed'
        }

    }
}
