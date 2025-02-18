using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
//johans script
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
        // Om den aktuella timmen är mellan 8 och 16 
        if (DateTime.Now.Hour > 7 && DateTime.Now.Hour < 17) // Det ska byta färg på bakgrunden i sync med realtime
        {
            // Minska värdet på timeChange, vilket gradvis förflyttar färgen mot dayTime
            timeChange -= 0.25f * Time.deltaTime;
        }
        else
        {
            // öka värdet på timeChange, vilket gradvis förflyttar färgen mot nightTime
            timeChange += 0.25f * Time.deltaTime;
        }

        // att timeChange alltid ligger inom intervallet 0 till 1
        timeChange = Mathf.Clamp(timeChange, 0, 1);

        // blndar (lerpar) färgerna dayTime och nightTime baserat på värdet av timeChange,
        // och sätter den blandade färgen som bakgrundsfärg för kameran.
        cam.backgroundColor = Color.Lerp(dayTime, nightTime, timeChange);

    }

}
