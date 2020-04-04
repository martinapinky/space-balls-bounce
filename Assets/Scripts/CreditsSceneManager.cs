using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsSceneManager : MonoBehaviour
{
    public GameObject fireworks1;
    public GameObject fireworks2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartMenu()
    {
        SceneManager.LoadScene("StartGame");
    }

    public void ShowFireworks1()
    {
        fireworks1.SetActive(true);
        Invoke("ShowFireworks2", 1f);
        Invoke("StartMenu", 3f);
    }

    public void ShowFireworks2()
    {
        fireworks2.SetActive(true);
    }


}
