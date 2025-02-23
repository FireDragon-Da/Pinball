using UnityEngine;

public class Portal : MonoBehaviour
{
    public Transform exitPortal; 
    public float cooldownTime = 1.5f; 
    private bool isOnCooldown = false; 
    private static bool exitOnCooldown = false;
    public AudioSource teleportSound;

     private void Start()
    {
        if (teleportSound == null)
        {
            teleportSound = GetComponent<AudioSource>(); 
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball") && exitPortal != null && !isOnCooldown && !exitOnCooldown)
        {
            StartCoroutine(TeleportBall(other.gameObject));
        }
    }

    private System.Collections.IEnumerator TeleportBall(GameObject ball)
    {
        isOnCooldown = true; 
        exitOnCooldown = true; 

        if (teleportSound != null)
        {
            teleportSound.Play(); 
        }
        
        ball.transform.position = exitPortal.position;
        Rigidbody2D rb = ball.GetComponent<Rigidbody2D>();
        rb.linearVelocity = Vector2.zero; 
        
        yield return new WaitForSeconds(cooldownTime); 
        isOnCooldown = false; 
        exitOnCooldown = false;
    }
}
