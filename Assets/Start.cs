using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    [SerializeField] GameObject canvas;//h�mtar b�da canvas i en Array
    [SerializeField] GameObject canvas2;

    public void Close()//funktionen g�r s� att startsk�rmen (canvas) blir osynlig och canvas2 blir synlig
    {
        if (canvas != null) 
        {
           // SceneManager.LoadScene(1);
            canvas.SetActive(false);
            canvas2.SetActive(true);
        }
        else //om inte det funkar 
        {
            Debug.LogWarning("Canvas is not assigned in the inspector");
        }

    }   
}