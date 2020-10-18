using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour
{
    public float playtime;
    void Start()
    {

    }

    void GameWin()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    private float timeLeft = 0;
    void Update()
    {
        timeLeft += Time.deltaTime;
        if (timeLeft > playtime)
        {
            GameWin();
        }
        
    }
}