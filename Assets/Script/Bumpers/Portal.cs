using UnityEngine;

public class Portal : MonoBehaviour
{
    public Transform exitPortal; 
    public float cooldownTime = 1.5f; 
    private bool isOnCooldown = false; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball") && exitPortal != null && !isOnCooldown)
        {
            StartCoroutine(TeleportBall(other.gameObject));
        }
    }

    private System.Collections.IEnumerator TeleportBall(GameObject ball)
    {
        isOnCooldown = true; 
        ball.transform.position = exitPortal.position;
        Rigidbody2D rb = ball.GetComponent<Rigidbody2D>();
        rb.linearVelocity = Vector2.zero; 
        
        yield return new WaitForSeconds(cooldownTime); 
        isOnCooldown = false; 
    }
}
