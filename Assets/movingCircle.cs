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

        transform.position = Vector3.Lerp(transform.position, punkt[current], Time.deltaTime * 25);//Interpolerad r�relse

        if (Vector3.Distance(transform.position, punkt[current]) < 0.1f) //Kontroll av n�r m�lpunkten �r n�d
        {
            if (movingForward)  // om vi r�r oss fram�t i listan
            {
                // G� till n�sta punkt
                current++;     
                if (current >= punkt.Length) // Om vi har n�tt slutet p� listan
                {
                    current = punkt.Length - 1;   // Stanna vid sista punkten

                    // byt riktning till bak�t
                    movingForward = false;        
                }
            }
            else // om vi r�r oss bak�t i listan
            {
                current--; // g� till f�reg�ende punkt
                if (current < 0) // Om vi har g�tt f�rbi den f�rsta punkten
                {
                    current = 1;       // s�tt till andra punkten (f�r att inte fastna p� f�rsta punkten)
                    movingForward = true; // byt riktning till fram�t
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

