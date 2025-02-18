using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovingCircle : MonoBehaviour
{
    [SerializeField] Vector3[] punkt;
    int current = 0;
    bool movingForward = true;

    void Update() 
    {
        if (punkt.Length < 2) return;

        transform.position = Vector3.Lerp(transform.position, punkt[current], Time.deltaTime * 25); //array 

        if (Vector3.Distance(transform.position, punkt[current]) < 0.1f)
        {
            if (movingForward)
            {
                current++;
                if (current >= punkt.Length)
                {
                    current = punkt.Length - 1;
                    movingForward = false;
                }
            }
            else
            {
                current--;
                if (current < 0)
                {
                    current = 1;
                    movingForward = true;
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) //funktion
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

