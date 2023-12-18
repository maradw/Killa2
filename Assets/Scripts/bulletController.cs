using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController : MonoBehaviour
{
    public float Speed;
    private Rigidbody2D _compRigidBody;
    // Start is called before the first frame update
    void Awake()
    {
        _compRigidBody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _compRigidBody.velocity = new Vector2(Speed * 1, 0);
    }
    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag =="littleEnemy")
        {
            Destroy(this.gameObject);
        }
        else if(collision.gameObject.tag == "floor")
        {
            Destroy(this.gameObject);
        }
    }*/
   private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "littleEnemy")
        {
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.tag == "floor")
        {
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.tag == "stone")
        {
            Destroy(this.gameObject);
        }
    }
}
