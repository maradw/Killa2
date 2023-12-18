using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneControl : MonoBehaviour
{
    protected float _numb;
    protected string _name;
    protected bool _taken;
    public GameObject _Killa3;
    public GameManager _thirdGameManager;

    protected virtual void AddTo()
    {
        int rnd = Random.Range(1, 10);
        float addToMision = _numb * (_name.Length * 0.10f) + rnd;
        _thirdGameManager.Mission(addToMision);

    }
    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _taken = true;
            AddTo();

        }
    }*/
    public void SetGameManager(GameManager lastGameManager)
    {
        _thirdGameManager = lastGameManager;
    }
    public void SetNewKilla(GameObject killa3)
    {
        _Killa3 = killa3;
    }
}
