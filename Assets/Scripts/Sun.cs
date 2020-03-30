using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().ScoreUp();

        SoundManagerScript.PlaySound("explosion");
        explosion.SetActive(true);
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SoundManagerScript.PlaySound("impact");
    }
}
