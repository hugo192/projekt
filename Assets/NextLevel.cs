using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    [SerializeField] int sceneIndex;
    // Start is called before the first frame update - Hugo
    void Start()
    {
        
    }

    // Update is called once per frame - Hugo
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)//Om man colliderar med objektet teleporteras man till nästa level - Hugo
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
