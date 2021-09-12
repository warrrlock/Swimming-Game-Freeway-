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

    private SoundManager soundManager;

    // Start is called before the first frame update
    void Start()
    {
        P1hit = false;
        soundManager = FindObjectOfType<SoundManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && !P1hit)
        {
            if (!soundManager.isPlaying("player_1"))
                soundManager.playSound(soundManager.getClip("player1"), "player_1",1);
            transform.Translate(0, speed * Time.deltaTime, 0);
            
        }

        if (Input.GetKey(KeyCode.S) && !P1hit)
        {
            if (!soundManager.isPlaying("player_1"))
                soundManager.playSound(soundManager.getClip("player1"), "player_1",1);
            transform.Translate(0, -speed * Time.deltaTime, 0);
            
        }

        if (P1hit) 
        {
            soundManager.stopPlaySound("player_1");
            soundManager.playSound(soundManager.getClip("hitted"), "player_1",0.5f);
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
