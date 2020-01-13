using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 4000f; //how fast the player moves forward
    public float sidewaysForce = 100f; //how fast the player can move side to side

    // Update is called once per frame
    void FixedUpdate()
    {
       
        rb.AddForce(0, 0, forwardForce*Time.deltaTime); //apply the forward force

        if(Input.GetKey("d")) //if the "d" key is pressed,
        {
            rb.AddForce(sidewaysForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange); //instantly move the player to the right
        }

        if (Input.GetKey("a")) //if the "a" key is pressed,     
        {
            rb.AddForce(-sidewaysForce* Time.deltaTime, 0, 0, ForceMode.VelocityChange); //instantly move the player to the left
        }

        
    }
}
