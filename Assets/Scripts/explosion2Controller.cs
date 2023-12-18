using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion2Controller : MonoBehaviour
{
    float currentTime;
    float limitTime = 0.7f;

    void Update()
    {
        currentTime = currentTime + Time.deltaTime;
        if (currentTime >= limitTime)
        {
            Destroy(this.gameObject);
        }
    }
}
