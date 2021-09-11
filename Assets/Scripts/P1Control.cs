using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Control : MonoBehaviour
{
    public float speed = 1f;
    public float knockforce;
    public bool knockback;
    public static bool P1hit;
    public float hittime;
    public float hittimeMAX;
    public Rigidbody2D P1RigidBody;
    //public Rigidbody2D thisRigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        P1hit = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && !P1hit)
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
            
        }

        if (Input.GetKey(KeyCode.S) && !P1hit)
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
            
        }

        if (P1hit) 
        {
            P1RigidBody.AddForce(Vector2.down * knockforce, ForceMode2D.Impulse);
            hittime++;
        }

        if (hittime >= hittimeMAX)
        {
            P1hit = false;
            hittime = 0;
        }
    }
   
}
