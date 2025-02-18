using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class daynight : MonoBehaviour
{
    Camera cam;
    [SerializeField] Color dayTime = new Color(0.05899668f, 0.7898433f, 0.9874213f, 1);
    [SerializeField] Color nightTime = new Color(0, 0, 0, 1);
    float timeChange = 0;
    
    // Start is alled before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (DateTime.Now.Hour > 7 && DateTime.Now.Hour < 17)
        {
            timeChange -= 0.25f * Time.deltaTime;
        }
        else
        {
            timeChange += 0.25f * Time.deltaTime;
        }
        timeChange = Mathf.Clamp(timeChange, 0, 1);
        cam.backgroundColor = Color.Lerp(dayTime, nightTime, timeChange);
    }
}
