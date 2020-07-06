using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    float x, y;
    float t = 0.0f;
    float waitingTime = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        x = Random.Range(0.0f, 1.0f);
        y = Random.Range(0.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(x, y, 0);


        if (Time.time > t) {
            x = Random.Range(0.0f, 1.0f);
            y = Random.Range(0.0f, 1.0f);
            t += waitingTime;
        }


    }
}
