using UnityEngine;

public class BackgroundMusicManager : MonoBehaviour
{
    public AudioClip backgroundMusic; // Your background music audio clip
    private AudioSource audioSource;

    void Start()
    {
        // Get the AudioSource component
        audioSource = GetComponent<AudioSource>();
        
        // Set the background music and start playing
        audioSource.clip = backgroundMusic;
        audioSource.loop = true; // Enable looping
        audioSource.Play(); // Start playing the music
    }
}
