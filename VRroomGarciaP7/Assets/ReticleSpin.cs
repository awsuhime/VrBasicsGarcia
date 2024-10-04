using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class ReticleSpin : MonoBehaviour
{
    public GameObject reticle;
    public int speed = 3;
    public float bounceSpeed = 0.01f;
    public bool increasing = false;
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 funny = new (0, 1, 0);
        reticle.transform.Rotate(funny * Time.deltaTime * speed);
        
        
    }

    private void FixedUpdate()
    {
        if (reticle.transform.localScale.x >= 1f)
        {
            increasing = false;
        }
        else if (reticle.transform.localScale.x <= 0.8f)
        {
            increasing = true;
        }
        if (increasing)
        {
            reticle.transform.localScale = new Vector3(reticle.transform.localScale.x + bounceSpeed, 1, reticle.transform.localScale.x + bounceSpeed);
        }
        if (!increasing)
        {
            reticle.transform.localScale = new Vector3(reticle.transform.localScale.x - bounceSpeed, 1, reticle.transform.localScale.x - bounceSpeed);
        }
    }
}
