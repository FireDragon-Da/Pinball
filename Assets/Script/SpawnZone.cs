using UnityEngine;

public class SpawnZone : MonoBehaviour
{
    public Spring launcher; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            launcher.canCharge = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            launcher.canCharge = false;
        }
    }
}
