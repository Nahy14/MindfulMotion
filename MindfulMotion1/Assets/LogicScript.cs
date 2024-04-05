using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//to manage ui
using UnityEngine.SceneManagement;//to manage a scene

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    [ContextMenu("Increase score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Over()
    {
        gameOverScreen.SetActive(true);
    }
}
