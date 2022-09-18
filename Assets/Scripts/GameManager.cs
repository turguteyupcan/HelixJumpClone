using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int score = 0;
    public Text scoreText;
    public GameObject WinPanel;

    public void GameScore(int ringScore)
    {
        score += ringScore;
        scoreText.text=score.ToString();
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Win()
    {
        WinPanel.SetActive(true);
    }
}
