using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Create singleton so we can access anything here from any other script
    //public static GameManager instance;

    public GameObject restartButton;
    public GameObject exitText;
    public Text timeText1;
    public TextMeshProUGUI timeText2;
    public TextMeshProUGUI bestTimeText;
    public TextMeshProUGUI winText;

    public GameObject fireworks1;
    public GameObject fireworks2;

    int ballsDestroyed = 0;

    //void Awake()
    //{
    //    if (instance == null)
    //    {
    //        instance = this;
    //    }
    //}

    // Start is called before the first frame update
    void Start()
    {
        //timeText2 = GetComponent<TextMeshPro>();
        //bestTimeText = GetComponent<TextMeshPro>();
        ScoreManager.instance.StartScore();
    }

    // Update is called once per frame
    void Update()
    {
        string time = "Time: " + PlayerPrefs.GetInt("time").ToString() + "s";
        timeText1.text = time;
    }

    public void ScoreUp()
    {
        ballsDestroyed++;
        if (ballsDestroyed >= 6)
        {
            Win();
        }
    }

    void Win()
    {

        ScoreManager.instance.StopScore();

        if (PlayerPrefs.HasKey("newHighScore") && PlayerPrefs.GetInt("newHighScore") == 1)
        {
            winText.text = "NEW HIGH SCORE!";
            Invoke("ShowFireworks", 1f);
        } else
        {
            Invoke("ShowFireworks", 1f);
        }

        winText.gameObject.SetActive(true);
        restartButton.SetActive(true);
        exitText.SetActive(true);
        timeText2.text = "Time: " + PlayerPrefs.GetInt("time").ToString() + "s";
        bestTimeText.text = "Best Time: " + PlayerPrefs.GetInt("bestTime").ToString() + "s";
        timeText2.gameObject.SetActive(true);
        bestTimeText.gameObject.SetActive(true);
        timeText1.gameObject.SetActive(false);

        SoundManagerScript.PlaySound("celebration");
    }

    public void Restart()
    {
        SoundManagerScript.PlaySound("menu");
        SceneManager.LoadScene("Game");
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

    public void ShowFireworks()
    {
        fireworks1.SetActive(true);
        Invoke("Fireworks2", 2f);
    }

    public void Fireworks2()
    {
        fireworks2.SetActive(true);
    }
}
