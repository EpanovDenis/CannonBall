using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject WinnerPanel;
    public GameObject GameOverPanel;
    public GameObject PSGameOver;
    public GameObject Player;
    public GameObject GameWinnerPanel;
    public Text ScoreLevelText;
    public Text ScoreWinPanel;
    public GameObject PS;

    //private Animator anim;
    private Rigidbody rb;
    private bool flag = false;
    private int score = 0;

    void Start()
    {
        //anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }
        
    void Update()
    {
        //anim.SetFloat("Velocity", rb.velocity.magnitude);    
    }    

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "DeathTrigger")
        {
            Player.SetActive(false);
            PSGameOver.SetActive(true);            
            GameOverPanel.SetActive(true);
            flag = true;
            Invoke("TimeZero", 1f);
        }

        if (other.name == "WinnerTrigger" && SceneManager.GetActiveScene().buildIndex != 6)
        {
            Time.timeScale = 0;
            WinnerPanel.SetActive(true);
        }

        if (other.name == "WinnerTrigger" && SceneManager.GetActiveScene().buildIndex == 6)
        {            
            PS.SetActive(true);
            GameWinnerPanel.SetActive(true);
            flag = true;
            Invoke("TimeZero", 2f);
        }

        if (other.tag == "Badground")
        {
            other.gameObject.AddComponent<Rigidbody>();
        }

        if (other.tag == "Bonus")
        {
            score++;
            ScoreLevelText.text = "SCORE:" + score;   
            ScoreWinPanel.text = "YOU SCORE:" + score;
        }
    }

    private void TimeZero()
    {
        if (flag == true)
        {
            Time.timeScale = 0;
        }
    }
}
