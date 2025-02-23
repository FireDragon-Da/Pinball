using UnityEngine;

public class Breakable : MonoBehaviour
{
    public int scoreValue = 50; 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            FindObjectOfType<ScoreManager>().AddScore(scoreValue); 
            Destroy(gameObject); 
        }
    }
}
