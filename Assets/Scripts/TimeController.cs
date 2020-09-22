using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    private const float interval = 3.0f;
    private int intervalCounter = 1;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");

    }

    // Update is called once per frame
    void Update()
    {
        if ((float)intervalCounter * interval < Time.time)
        {
            intervalCounter += 1;
            Debug.Log("Count up");
        }

    }

    public bool currentStatus()
    {
        if(intervalCounter % 2 == 0)
        {
            return true;
        }
        return false;
    }
}
