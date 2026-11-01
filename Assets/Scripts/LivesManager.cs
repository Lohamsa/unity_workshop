using UnityEngine;
using TMPro;

public class LivesManager : MonoBehaviour
{
    public TMP_Text livesText;
    public TMP_Text gameOverText;

    private int lives = 3;
    private bool gameEnded = false;

    void Start()
    {
        Time.timeScale = 1f;

        lives = 3;
        UpdateLives();

        if (gameOverText != null)
        {
            gameOverText.gameObject.SetActive(false);
        }
    }

    public void LoseLife()
    {
        if (gameEnded)
        {
            return;
        }

        lives--;

        UpdateLives();

        Debug.Log("Lives remaining: " + lives);

        if (lives <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        gameEnded = true;

        if (gameOverText != null)
        {
            gameOverText.gameObject.SetActive(true);
        }

        Debug.Log("GAME OVER!");

        Time.timeScale = 0f;
    }

    void UpdateLives()
    {
        if (livesText != null)
        {
            livesText.text = "Lives: " + lives;
        }
        else
        {
            Debug.LogError("Please assign LivesText in Inspector!");
        }
    }
}