using UnityEngine;

public class AppleFall : MonoBehaviour
{
    public float speed = 3f;

    LivesManager livesManager;
    ScoreManager scoreManager;

    bool isCaught = false;

    void Start()
    {
        livesManager = FindAnyObjectByType<LivesManager>();
        scoreManager = FindAnyObjectByType<ScoreManager>();
    }

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        // Lose life only when apple goes below the screen
        if (transform.position.y < -6f && !isCaught)
        {
            if (livesManager != null)
            {
                livesManager.LoseLife();
            }

            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Catcher") && !isCaught)
        {
            isCaught = true;

            if (scoreManager != null)
            {
                scoreManager.AddScore();
            }

            Destroy(gameObject);
        }
    }
}