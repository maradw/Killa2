using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueStone : StoneControl
{
    void Start()
    {
        _numb = 15;
        _name = "enemies";
        _taken = false;
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
    protected override void AddTo()
    {
        float rnd = Random.Range(1, 10);
        float calculate = _numb * (_name.Length* 0.10f);

        float addToMision = -1*(calculate - rnd);
        _thirdGameManager.Mission(addToMision);

    }

}
