using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwimmerMove : MonoBehaviour
{
    public bool TopRow;
    public bool BotRow;
    public float speed = 2.0f;
    private SoundManager soundManager;

    // Start is called before the first frame update
    void Start()
    {
        soundManager = FindObjectOfType<SoundManager>();
        speed = Random.Range(1.0f, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (BotRow)
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }

        else if (TopRow) {
            transform.position += transform.right * -speed * Time.deltaTime;
        }

        if (!soundManager.isPlaying("effect"))
        {
            if (distanceFromPlayer() < 20)
            {
                soundManager.playSound(soundManager.getClip("swim1"), "effect");
            }
        }
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "P1" && P1Control.P1hit == false)
        {
            P1Control.P1hit = true;
            Debug.Log("p1 knock");
        }

        if (other.gameObject.name =="P2" && P2Control.P2hit == false)
        {
            P2Control.P2hit = true;
            Debug.Log("p2 knock");
        }

    }

    public float distanceFromPlayer()
    {
        if (Vector2.Distance(gameObject.transform.position, FindObjectOfType<P1Control>().gameObject.transform.position) >
            Vector2.Distance(gameObject.transform.position, FindObjectOfType<P2Control>().gameObject.transform.position))
        {
            return Vector2.Distance(gameObject.transform.position, FindObjectOfType<P1Control>().gameObject.transform.position);
        } else
        {
            return Vector2.Distance(gameObject.transform.position, FindObjectOfType<P2Control>().gameObject.transform.position);
        }
    }
}
