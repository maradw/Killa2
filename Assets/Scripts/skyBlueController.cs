using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyBlueController : MonoBehaviour
{
    float currentTime;
    float timeLimit = 0.7f;

    void Update()
    {
        currentTime = currentTime + Time.deltaTime;
        if(currentTime >= timeLimit)
        {
            Destroy(this.gameObject);
        }
    }
}
