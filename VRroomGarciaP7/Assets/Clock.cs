using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public GameObject hour;
    public GameObject minute;
    public GameObject second;
    void Start()
    {
        
    }

    void Update()
    {
        float hourTime = DateTime.Now.Hour;
        hour.transform.rotation = Quaternion.Euler(-hourTime + 90f, 0f, 0f);
        float minuteTime = DateTime.Now.Minute;
        minute.transform.rotation = Quaternion.Euler(-hourTime + 90f, 0f, 0f);
        float secondTime = DateTime.Now.Second;
        second.transform.rotation = Quaternion.Euler(-secondTime + 90f, 0f, 0f);
    }
}
