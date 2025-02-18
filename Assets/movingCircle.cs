using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//johans script
public class MovingCircle : MonoBehaviour
{
    [SerializeField] Vector3[] punkt; //En array som samlar ihop tre punkter
    int current = 0;
    bool movingForward = true;
    
    void Update()
    {
        if (punkt.Length < 2) return;//kontroll av antalet punkter

        transform.position = Vector3.Lerp(transform.position, punkt[current], Time.deltaTime * 25);//Interpolerad rörelse

        if (Vector3.Distance(transform.position, punkt[current]) < 0.1f) //Kontroll av nör målpunkten är nåd
        {
            if (movingForward)  // om vi rör oss framåt i listan
            {
                // Gå till nästa punkt
                current++;     
                if (current >= punkt.Length) // Om vi har nått slutet på listan
                {
                    current = punkt.Length - 1;   // Stanna vid sista punkten

                    // byt riktning till bakåt
                    movingForward = false;        
                }
            }
            else // om vi rör oss bakåt i listan
            {
                current--; // gå till föregående punkt
                if (current < 0) // Om vi har gått förbi den första punkten
                {
                    current = 1;       // sätt till andra punkten (för att inte fastna på första punkten)
                    movingForward = true; // byt riktning till framåt
                }
            }

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)//Om spelaren colliderar med en spik startar spelet om
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

