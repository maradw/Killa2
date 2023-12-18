using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    [HeaderAttribute(" Score variables")]
    int score;
    public Text scoreText;
    public Text mission;
    float missionBAr;
    [HeaderAttribute(" Life variables")]
    public Image greenLifeBar;
    float currentLife = 100;
    float maxLife= 100;
    float minLife= 0;
    [HeaderAttribute(" Stone variables")]
    float currentStonePoints = 0;
    float maxStonePoints = 100;
  

    void LifeInGame()
    {
       greenLifeBar.fillAmount = currentLife / maxLife;
    }
    void Update()
    {
        LifeInGame();
        State();
    }
    public void CurrentScore(int numb)
    {
        score = score + numb;
        scoreText.text = "Score: " + score;
        
    }
    public void Mission(float mNumb)
    {
        missionBAr = missionBAr + mNumb;
        currentStonePoints = missionBAr;
        mission.text = missionBAr+"/100";
    }
    public void  CurrentLifeInGame(float numb)
    {
        currentLife = currentLife - numb;
        
    }
    public void State()
    {
        if (currentLife <= 0)
        {
            SceneManager.LoadScene("Lose");
            //print("has muerto");
        }

        if (currentStonePoints >= 100)
        {
            SceneManager.LoadScene("Win");
        }
    }
    

}
