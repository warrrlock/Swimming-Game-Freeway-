using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndzoneScript : MonoBehaviour
{
    SoundManager soundManager;
    // Start is called before the first frame update
    void Start()
    {
        soundManager = FindObjectOfType<SoundManager>();
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "P1")
        {
            soundManager.stopPlaySound("player_1");
            soundManager.playSound(soundManager.getClip("point"), "player_1", 1);
            ScoreScript.P1Score += 1;
            other.transform.position = new Vector3(-2.07f, -4.21f, transform.position.z);
        }

        if (other.gameObject.name == "P2")
        {
            soundManager.stopPlaySound("player_2");
            soundManager.playSound(soundManager.getClip("point"), "player_2", 1);
            ScoreScript.P2Score += 1;
            other.transform.position = new Vector3(2.18f, -4.21f, transform.position.z);
        }
    }
}
