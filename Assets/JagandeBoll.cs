using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JagandeBoll : MonoBehaviour
{
    Collider2D[] objectsNearby;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        objectsNearby = Physics2D.OverlapCircleAll(transform.position, 5);
        for (int i = 0; i < objectsNearby.Length; i++)
        {
            if (objectsNearby[i].transform.CompareTag("Player"))
            {
                transform.position += (objectsNearby[i].transform.position - transform.position).normalized * 5 * Time.deltaTime;
            }
        }
    }
}
