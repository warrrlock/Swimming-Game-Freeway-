using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int P1Score = 0;
    public static int P2Score = 0;
    Text P1Scoretext;
    Text P2Scoretext;
    void Start()
    {
        P1Scoretext = GameObject.Find("P1Score").GetComponent<Text>();
        P2Scoretext = GameObject.Find("P2Score").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        P1Scoretext.text = "" + P1Score;
        P2Scoretext.text = "" + P2Score;
    }
}
