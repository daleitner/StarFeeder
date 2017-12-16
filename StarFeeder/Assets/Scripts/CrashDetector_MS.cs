using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashDetector_MS : MonoBehaviour
{
    static int countMeteors;

    void OnTriggerEnter(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Meteroid"))
        {
            Destroy(coll.gameObject);
            countMeteors += 1;

        }
        if (coll.gameObject.CompareTag("Meteroid_2"))
        {
            Destroy(coll.gameObject);
            countMeteors += 2;
        }
        if (coll.gameObject.CompareTag("Meteroid_3"))
        {
            Destroy(coll.gameObject);
            countMeteors += 3;

        }
        if (coll.gameObject.CompareTag("Meteroid_4"))
        {
            Destroy(coll.gameObject);
            countMeteors += 4;
        }
    }
}