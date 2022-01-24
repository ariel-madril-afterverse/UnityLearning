using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowCode : MonoBehaviour
{
    private float timeValueRed;
    private float timeValueGreen;
    private float timeValueBlue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Renderer>().material.color = ColorForTime();
        DoStuffLoop();
        DoSomethingElse();
    }

    void DoStuffLoop()
    {
        for (int i = 0; i < 1000; i++)
        {
            GetComponent<Renderer>().material.color = ColorForTime();
        }
    }

    private Color ColorForTime()
    {
        timeValueRed += Time.deltaTime;
        if (timeValueRed > 1f)
            timeValueRed -= 1f;

        timeValueGreen += Time.deltaTime * 2f;
        if (timeValueGreen > 1f)
            timeValueGreen -= 1f;
        
        timeValueBlue += Time.deltaTime * 3f;
        if (timeValueBlue > 1f)
            timeValueBlue -= 1f;

        return new Color(timeValueRed, timeValueGreen, timeValueBlue);
    }

    private void DoSomethingElse()
    {
        Debug.Log("Im Slow");
    }
}
