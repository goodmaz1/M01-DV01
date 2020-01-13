
using UnityEngine;

public class LookAway : MonoBehaviour
{
    public Transform player;
    public Vector3 away;

    // Update is called once per frame
    void Update()
    {
        Vector3 away = transform.position - player.transform.position;
        transform.rotation = Quaternion.LookRotation(away);
    }
}
