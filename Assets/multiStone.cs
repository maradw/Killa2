using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multiStone : StoneControl
{
    void Start()
    {
        _numb = 8;
        _name = " friends";
        _taken = false;
    }
    protected override void AddTo()
    {
        int rnd = Random.Range(-10, 10);
        float addToMision = _numb * (_name.Length*0.10f) - rnd;
        _thirdGameManager.Mission(addToMision);
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
