using UnityEngine;

public class SpWall : MonoBehaviour
{
    public float springForce ; 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Rigidbody2D ballRb = collision.gameObject.GetComponent<Rigidbody2D>();
            Vector2 bounceDirection = collision.contacts[0].normal * -1f;
            ballRb.linearVelocity = bounceDirection * springForce; 
        }
    }
}
