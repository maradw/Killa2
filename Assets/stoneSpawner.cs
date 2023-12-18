using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stoneSpawner : MonoBehaviour
{
    public GameObject[] stoneArray = new GameObject[3];
    public GameManager AnotherGameManager;
    public GameObject _Killa4;
    void Start()
    {
        float newTime = Random.Range(0.5f, 3);
        Invoke("CreateStones", newTime);
    }

    public void CreateStones()
    {
        float x = Random.Range(-5.57f, 32.28f);
        float y = Random.Range(-3f, 3f);
        float newTime = Random.Range(1f, 6f);
        Vector2 positionStone = new Vector2(x, y);
        RandomNumb(positionStone);
        Invoke("CreateStones", newTime);
    }
    public void RandomNumb(Vector2 position)
    {
        int newrnd = Random.Range(0, 4);
        for(int i = 0; i < stoneArray.Length; i++)
        {
            if (newrnd == 1)
            {
                GameObject first = Instantiate(stoneArray[0], position, transform.rotation);
                first.GetComponent<StoneControl>().SetGameManager(AnotherGameManager);
                first.GetComponent<StoneControl>().SetNewKilla(_Killa4);
            }
            else if (newrnd == 2)
            {
                GameObject second =Instantiate(stoneArray[1], position, transform.rotation);
                second.GetComponent<StoneControl>().SetGameManager(AnotherGameManager);
                second.GetComponent<StoneControl>().SetNewKilla(_Killa4);
            }
            else if (newrnd == 3)
            {
                
                GameObject third= Instantiate(stoneArray[2], position, transform.rotation);
                third.GetComponent<StoneControl>().SetGameManager(AnotherGameManager);
                third.GetComponent<StoneControl>().SetNewKilla(_Killa4);
            }
        }
    }
}
