using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControl : MonoBehaviour
{
    public GameObject killaCharacter;
    public float minXposition;
    public float maxXposition;
    public float minYposition;
    public float maxYposition;
    private float Xposition;
    private float Yposition;
   // private Vector3 velocityReference;
    //public float cameraSpeed;

    void Update()
    {
        transform.position = new Vector3(killaCharacter.transform.position.x, killaCharacter.transform.position.y, -10);
        Xposition = Mathf.Clamp(transform.position.x, minXposition, maxXposition);
        Yposition = Mathf.Clamp(transform.position.y, minYposition, maxYposition);

       // Vector3 killaCamera = new Vector3(killaCharacter.transform.position.x, killaCharacter.transform.position.y, -10);
        transform.position = new Vector3(Xposition, Yposition, -10);
        
        /*Xposition = Mathf.Clamp(killaCharacter.transform.position.x, minXposition, maxXposition);
        Yposition = Mathf.Clamp(killaCharacter.transform.position.y, minYposition, maxYposition);
        Vector3 ekisde = new Vector3(Xposition, Yposition, -10);
        //Vector3 killaCamera = new Vector3(killaCharacter.transform.position.x, killaCharacter.transform.position.y, -10);
        //transform.position = new Vector3(Xposition, Yposition, -10);
        transform.position = Vector3.SmoothDamp(transform.position, ekisde, ref velocityReference, cameraSpeed*Time.deltaTime);*/
    }
}
