using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class littleEnemyController : MonoBehaviour
{
    public float speed;
    private Rigidbody2D _compRigidbody;
    public GameObject skyExplosionPrefab;
    public GameManager _gameManager;
    // Start is called before the first frame update
    private void Awake()
    {
        _compRigidbody = GetComponent<Rigidbody2D>();
    }
    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "bullet")
        {
            Destroy(this.gameObject);
            _gameManager.CurrentScore(5);
            Instantiate(skyExplosionPrefab, transform.position, transform.rotation);
        }
    }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "floor"  )
        {
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.tag == "bullet")
        {
            Destroy(this.gameObject);
            _gameManager.CurrentScore(5);
            Instantiate(skyExplosionPrefab, transform.position, transform.rotation);
        }
    }

    void FixedUpdate()
    {
        _compRigidbody.velocity = new Vector2(0, speed * -1);
    }
    public void SetGameManager(GameManager scoreGameManager)
    {
        _gameManager = scoreGameManager;
    }
}

