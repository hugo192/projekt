using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)//Om spelaren colliderar med ett specifikt objekt s� startar man om
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene("Samplescene");
        }
    }
}
