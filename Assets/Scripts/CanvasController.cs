using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class CanvasController : MonoBehaviour
{
    public GameObject MainMenuPanel;
    public GameObject SelectLevelPanel;    
    public GameObject PausePanel;
    public GameObject PauseButton;
    public GameObject ScoreText;
    public Button NextLevelButton;            

    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 6)
        {
            NextLevelButton.interactable = false;
        }                
    }
      
    public void PlayButtonClick()
    {
        MainMenuPanel.SetActive(false);
        SelectLevelPanel.SetActive(true);
    }

    public void BackToMainMenuButtonClick()
    {
        SceneManager.LoadScene(0);
    }

    public void Level1ButtonClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
        SelectLevelPanel.SetActive(false);
        MainMenuPanel.SetActive(false);
        PauseButton.SetActive(true);
        ScoreText.SetActive(true);
    }

    public void Level2ButtonClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
        SelectLevelPanel.SetActive(false);
        MainMenuPanel.SetActive(false);
        PauseButton.SetActive(true);
        ScoreText.SetActive(true);
    }

    public void Level3ButtonClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(3);
        SelectLevelPanel.SetActive(false);
        MainMenuPanel.SetActive(false);
        PauseButton.SetActive(true);
        ScoreText.SetActive(true);
    }

    public void Level4ButtonClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(4);
        SelectLevelPanel.SetActive(false);
        MainMenuPanel.SetActive(false);
        PauseButton.SetActive(true);
        ScoreText.SetActive(true);
    }

    public void Level5ButtonClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(5);
        SelectLevelPanel.SetActive(false);
        MainMenuPanel.SetActive(false);
        PauseButton.SetActive(true);
        ScoreText.SetActive(true);
    }

    public void Level6ButtonClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(6);
        SelectLevelPanel.SetActive(false);
        MainMenuPanel.SetActive(false);
        PauseButton.SetActive(true);
        ScoreText.SetActive(true);
    }

    public void PauseButtonClick()
    {
        Time.timeScale = 0;
        PausePanel.SetActive(true);
        PauseButton.SetActive(false);
        ScoreText.SetActive(false);
    }

    public void BackToGameButtonClick()
    {
        Time.timeScale = 1;
        PausePanel.SetActive(false);
        PauseButton.SetActive(true);
        ScoreText.SetActive(true);
    }

    public void RestartButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void NextLevelButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1;
    }
}
