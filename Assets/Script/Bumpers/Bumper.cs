using UnityEngine;

public class Bumper : MonoBehaviour
{
    public int scoreValue; 
    public float bounceForce; // 反弹力度

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Rigidbody2D ballRb = collision.gameObject.GetComponent<Rigidbody2D>();
            Vector2 bounceDirection = collision.contacts[0].normal * -1f;
            ballRb.linearVelocity = bounceDirection * bounceForce; 

            FindObjectOfType<ScoreManager>().AddScore(scoreValue); 
        }
    }
}
