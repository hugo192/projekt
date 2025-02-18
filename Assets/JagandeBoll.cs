using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JagandeBoll : MonoBehaviour
{
    Collider2D[] objectsNearby;
    // Start is called before the first frame update
    void Start()
    {
        //johans script
    }

    // Update is called once per frame
    void Update() //.
    { //// Hitta alla objekt med en collider inom en cirkel med radie 5, centrerad runt detta objekts position.

        objectsNearby = Physics2D.OverlapCircleAll(transform.position, 5);
        //Loopar igenom alla hittade objekt.
        for (int i = 0; i < objectsNearby.Length; i++)
        {
            if (objectsNearby[i].transform.CompareTag("Player"))
            {
                //beräknar riktningen från detta objekt till spelarens position
                // .normalized gör att vi får en riktning

                transform.position += (objectsNearby[i].transform.position - transform.position).normalized * 4 * Time.deltaTime;
            }
        }
    }
}
