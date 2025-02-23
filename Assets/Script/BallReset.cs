using UnityEngine;

public class BallReset : MonoBehaviour
{
    public Transform ball;  
    public Vector3 startPosition; 

    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball")) 
        {
            ResetBall();
        }
    }

    void ResetBall()
    {
        ball.position = startPosition; 
        Rigidbody2D rb = ball.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.linearVelocity = Vector2.zero; 
            rb.angularVelocity = 0f; 
        }
    }
}
