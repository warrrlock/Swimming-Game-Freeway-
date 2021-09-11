using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Control : MonoBehaviour
{
    public float p2speed = 1f;
    public float p2knockforce;
    public bool p2knockback;
    public static bool P2hit;
    public float p2hittime;
    public float p2hittimeMAX;
    public Rigidbody2D P2RigidBody;
    //public Rigidbody2D thisRigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        P2hit = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && !P2hit)
        {
            transform.Translate(0, p2speed * Time.deltaTime, 0);

        }

        if (Input.GetKey(KeyCode.DownArrow) && !P2hit)
        {
            transform.Translate(0, -p2speed * Time.deltaTime, 0);

        }

        if (P2hit)
        {
            P2RigidBody.AddForce(Vector2.down * p2knockforce, ForceMode2D.Impulse);
            p2hittime++;
        }

        if (p2hittime >= p2hittimeMAX)
        {
            P2hit = false;
            p2hittime = 0;
        }
    }

}
