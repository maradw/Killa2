using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinkStone : StoneControl
{
    void Start()
    {
        _numb = 12;
        _name = "family";
        _taken = false;
    }

    protected override void AddTo()
    {
        base.AddTo();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _taken = true;
            AddTo();
            Destroy(this.gameObject);

        }
    }


}
