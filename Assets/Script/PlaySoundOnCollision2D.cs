using UnityEngine;

public class PlaySoundOnCollision2D : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball")) 
        {
            if (!audioSource.isPlaying) 
            {
                audioSource.Play();
            }
        }
    }
}
