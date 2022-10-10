using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject lwall;
    public GameObject rwall;
    public GameObject swall;
    public GameObject ewall;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == lwall)
        {
            Player.transform.position = new Vector3 (3.4f, 1.016f, Player.transform.position.z);
        }
        if (collision.gameObject == rwall)
        {
            Player.transform.position = new Vector3 (-3.4f, 1.016f, Player.transform.position.z);
        }
        if (collision.gameObject == ewall)
        {
            Player.transform.position = new Vector3 (Player.transform.position.x, 1.016f, -4.10f);
        }
        if (collision.gameObject == swall)
        {
            Player.transform.position = new Vector3 (Player.transform.position.x, 1.016f, 12.90f);
        }
        Debug. Log("Object that collided with me: " + collision.gameObject.name);
    }
}