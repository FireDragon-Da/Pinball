using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // 用于重新加载场景

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI livesText; 
    private int score = 0;
    private int lives = 3; 

    void Start()
    {
        UpdateUI();
    }

    public void AddScore(int points)
    {
        score += points;
        UpdateUI();
    }

    public void LoseLife()
    {
        lives--; 
        UpdateUI();

        if (lives <= 0)
        {
            GameOver();
        }
    }

    private void UpdateUI()
    {
        scoreText.text = "Score: " + score;
        livesText.text = "Lives: " + lives;
    }

    private void GameOver()
    {
        Debug.Log("Game Over! Restarting...");
        Invoke("RestartGame", 2f); 
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
    }
}
