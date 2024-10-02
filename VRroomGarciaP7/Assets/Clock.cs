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
        float minuteTime = DateTime.Now.Minute;
        float secondTime = DateTime.Now.Second;
        hour.transform.rotation = Quaternion.Euler(-hourTime * 6 - 90f, 0, 0);        
        minute.transform.rotation = Quaternion.Euler(-minuteTime * 6 - 90f, 0, 0);       
        second.transform.rotation = Quaternion.Euler(-secondTime * 6 - 90f, 0, 0);
        
    }
}
