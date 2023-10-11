using UnityEngine;

public class BGMController : MonoBehaviour
{
    public AudioSource musicSourceA; 
    public AudioSource musicSourceB;

    private bool isPlayingMusicB = false; 
    private Vector3 lastPlayerPosition; 
    private float fallDuration = 0f; 

    private void Start()
    {
        musicSourceA.enabled = true;
        musicSourceB.enabled = true;

        musicSourceA.Play(); 
        lastPlayerPosition = transform.position; 
    }

    private void Update()
    {
        Vector3 currentPlayerPosition = transform.position; 
        float yPositionDifference = lastPlayerPosition.y - currentPlayerPosition.y;

        if (yPositionDifference > 0)
        {
            fallDuration += Time.deltaTime; 

            if (fallDuration >= 1.5f && !isPlayingMusicB)
            {
                isPlayingMusicB = true;
                musicSourceA.Stop();
                musicSourceB.Play();
            }
        }
        else
        {
            fallDuration = 0f; 
        }

        lastPlayerPosition = currentPlayerPosition;

        if (!musicSourceB.isPlaying && isPlayingMusicB)
        {
            isPlayingMusicB = false;
            musicSourceB.Stop();
            musicSourceA.Play();
        }
    }
}
