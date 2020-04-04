using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StartSceneManager : MonoBehaviour
{

    public TextMeshProUGUI highScore;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("bestTime"))
        {
            highScore.text = PlayerPrefs.GetInt("bestTime").ToString() + "s";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SoundManagerScript.PlaySound("menu");
        SceneManager.LoadScene("Game");
    }

    public void ExitGame()
    {
        SoundManagerScript.PlaySound("menu");
        Application.Quit();
    }

    public void StartCredits()
    {
        SoundManagerScript.PlaySound("menu");
        SceneManager.LoadScene("credits");
    }
}
