using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Create singleton so we can access anything here from any other script
    public static ScoreManager instance;

    public int time;
    public int bestTime;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        PlayerPrefs.SetInt("time", time);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void IncrementScore()
    {
        time += 1;
        PlayerPrefs.SetInt("time", time);
    }

    public void StartScore()
    {
        PlayerPrefs.SetInt("newHighScore", 0);

        // Increment score by 1 every 1s after 1s
        InvokeRepeating("IncrementScore", 1f, 1f);
        
    }

    public void StopScore()
    {
        CancelInvoke("IncrementScore");
        PlayerPrefs.SetInt("time", time);
       

        // Check if the highscore has been stored before
        if (PlayerPrefs.HasKey("bestTime"))
        {
            // Set the new highScore as the current score if it is less 
            // than the previous highScore
            if (time < PlayerPrefs.GetInt("bestTime"))
            {
                PlayerPrefs.SetInt("bestTime", time);
                PlayerPrefs.SetInt("newHighScore", 1);
            }
        }
        else
        {
            PlayerPrefs.SetInt("bestTime", time);
        }
    }
}
