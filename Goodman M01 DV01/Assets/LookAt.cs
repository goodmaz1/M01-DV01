
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform player;
    public bool moving = false;
    public float speed = 10f;


    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);

        if (moving == true)
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
    }
}
