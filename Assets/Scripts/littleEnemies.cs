using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class littleEnemies : MonoBehaviour
{
    public GameObject _littleEnemiesPrefab;
 
    public GameManager _firstGameManager;

    void Start()
    { 
        float time = Random.Range(0.01f, 0.9f);
        Invoke("CreateLittleEnemy", time);
    }


    void CreateLittleEnemy()
    {
        float x = Random.Range(0.54f, 5.76f);
        Vector2 enemyPosition = new Vector2(x, 3.70f);
        float time = Random.Range(0.2f, 1.5f);
        GameObject littleEnemy = Instantiate(_littleEnemiesPrefab, enemyPosition, transform.rotation);

        littleEnemy.GetComponent<littleEnemyController>().SetGameManager(_firstGameManager);
        Invoke("CreateLittleEnemy", time);
    }
    
}
