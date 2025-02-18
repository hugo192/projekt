using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballscript : MonoBehaviour 
{
    [SerializeField] Vector3[] Ball; //array som samlar ihop alla punkter - Hugo
    int current;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        for (int i = 0; i < Ball.Length; i++)//vilka punkter bollen åker till
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
        transform.position += (Ball[current]-transform.position).normalized * 3 * Time.deltaTime; //hastigheten för hur snabbt bollen rör sig - Hugo
    }
}
