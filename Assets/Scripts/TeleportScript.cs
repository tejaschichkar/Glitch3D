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
            Player.transform.position = new Vector3 (3.6f, 0.4f, Player.transform.position.z);
        }
        if (collision.gameObject == rwall)
        {
            Player.transform.position = new Vector3 (-3.6f, 0.4f, Player.transform.position.z);
        }
        if (collision.gameObject == ewall)
        {
            Player.transform.position = new Vector3 (Player.transform.position.x, 0.4f, -4.25f);
        }
        if (collision.gameObject == swall)
        {
            Player.transform.position = new Vector3 (Player.transform.position.x, 0.4f, 13f);
        }
        Debug. Log("Object that collided with me: " + collision.gameObject.name);
    }
}