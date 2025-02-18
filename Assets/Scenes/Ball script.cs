using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballscript : MonoBehaviour
{
    [SerializeField] Vector3[] Ball;
    int current;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Ball.Length; i++)
        {
            if (Vector3.Distance(transform.position, Ball[i]) < 1)
            {
                current++;
                if (current >= Ball.Length)
                {
                    current = 0;
                }
            }
        }
        transform.position = Ball[current];
    }
}
