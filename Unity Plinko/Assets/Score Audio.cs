using UnityEngine;

public class ScoreAudio : MonoBehaviour
{
    public AudioClip scoreAudio;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (audioSource != null && scoreAudio != null)
        {
            audioSource.PlayOneShot(scoreAudio);
        }
    }
}
