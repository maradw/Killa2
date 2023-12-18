using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class merekSpawner : MonoBehaviour
{
    public GameObject merekPrefab;
    public GameManager _secondGameManager;
    public GameObject _newKilla;

    void Start()
    {
        float mTime = Random.Range(1.5f, 2f);
        Invoke("CreateMerekEnemies", mTime);
    }
    void CreateMerekEnemies()
    {
        float x = Random.Range(-1.2f,10.49f);
        float y = Random.Range(2.33f, -2.19f);
        float mTime = Random.Range(3f, 6f);
        Vector2 merekPosition = new Vector2(x, y);
        GameObject newMerek = Instantiate(merekPrefab, merekPosition, transform.rotation);

        newMerek.GetComponent<merekController>().SetGameManager(_secondGameManager);
        newMerek.GetComponent<merekController>().SetKilla(_newKilla);
        Invoke("CreateMerekEnemies", mTime);
    }
}
