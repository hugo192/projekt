using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Start : MonoBehaviour
{
    [SerializeField] GameObject canvas;
    [SerializeField] GameObject canvas2;

    public void Close()
    {
        if (canvas != null) 
        {
            canvas.SetActive(false);
            canvas2.SetActive(true);
        }
        else
        {
            Debug.LogWarning("Canvas is not assigned in the inspector");
        }

    }   
}