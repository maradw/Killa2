using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletOriginControl : MonoBehaviour
{
    public GameObject bulletPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
    }
}
