using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndzoneScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "P1")
        {
            ScoreScript.P1Score += 1;
            other.transform.position = new Vector3(-2.07f, -4.21f, transform.position.z);
        }

        if (other.gameObject.name == "P2")
        {
            ScoreScript.P2Score += 1;
            other.transform.position = new Vector3(2.18f, -4.21f, transform.position.z);
        }
    }
}
