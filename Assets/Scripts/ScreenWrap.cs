using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWrap : MonoBehaviour
{
    public bool TopRow;
    public bool BotRow;
    public SwimmerMove swimmermove;

    // Start is called before the first frame update
    void Start()
    {
        swimmermove = GetComponent<SwimmerMove>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= 7 && BotRow) {
            transform.position = new Vector3(-6.5757f, transform.position.y, transform.position.z);
            swimmermove.speed = Random.Range(1.0f, 5.0f);
        }

        else if (transform.position.x <= -6.5757f && TopRow)
        {
            transform.position = new Vector3(7, transform.position.y, transform.position.z);
            swimmermove.speed = Random.Range(1.0f, 5.0f);
        }

    }
}
