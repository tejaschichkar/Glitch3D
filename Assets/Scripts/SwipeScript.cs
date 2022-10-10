using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeScript : MonoBehaviour
{
    private Vector3 fp;
    private Vector3 lp;
    private float dragDistance;
    private float speed = 5;
 
    void Start()
    {
        dragDistance = Screen.height * 25 / 100;
    }
 
    void Update()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                fp = touch.position;
                lp = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                lp = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                lp = touch.position;
 
                if (Mathf.Abs(lp.x - fp.x) > dragDistance || Mathf.Abs(lp.y - fp.y) > dragDistance)
                {
                    if (Mathf.Abs(lp.x - fp.x) > Mathf.Abs(lp.y - fp.y))
                    {
                        if ((lp.x > fp.x))
                        {
                            GetComponent<Rigidbody>().velocity = new Vector3 (1f, 0, 0)*speed;
                            Debug.Log("Right Swipe");
                        }
                        else
                        {
                            GetComponent<Rigidbody>().velocity = new Vector3 (-1f, 0, 0)*speed;
                            Debug.Log("Left Swipe");
                        }
                    }
                    else
                    {
                        if (lp.y > fp.y)
                        {
                            GetComponent<Rigidbody>().velocity = new Vector3 (0, 0, 1f)*speed;
                            Debug.Log("Up Swipe");
                        }
                        else
                        {
                            GetComponent<Rigidbody>().velocity = new Vector3 (0, 0, -1f)*speed;
                            Debug.Log("Down Swipe");
                        }
                    }
                }
                else
                {
                    Debug.Log("Tap");
                }
            }
        }
    }

}
