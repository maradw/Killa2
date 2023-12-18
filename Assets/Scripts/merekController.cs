using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class merekController : MonoBehaviour
{
    private Rigidbody2D _comRigidbody2D;
    public GameObject explosion2Prefab;
    public float speedMovement;
    public GameObject _Killa;
    bool followKilla = false;
    public GameManager gameManagerForMerek;
    private void Awake()
    {
       // _comRigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (followKilla == true)
        {
            FollowCharacter();
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            Instantiate(explosion2Prefab, transform.position, transform.rotation);
        }

        else if (collision.gameObject.tag == "bullet")
        {
            Destroy(this.gameObject);
            gameManagerForMerek.CurrentScore(15);
            Instantiate(explosion2Prefab, transform.position, transform.rotation);//originaltrigger
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.gameObject.tag == "follow")
        {
            followKilla = true;
            
        }
    }
    void FollowCharacter()
    {
        transform.position = Vector2.MoveTowards(this.transform.position, _Killa.transform.position, speedMovement * Time.deltaTime);
    }
    public void SetGameManager(GameManager newGameManager)
    {
        gameManagerForMerek = newGameManager;
    }
    public void SetKilla(GameObject killaskz)
    {
        _Killa = killaskz;
    }
}
