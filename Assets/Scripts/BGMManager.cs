using UnityEngine;

public class BGMController : MonoBehaviour
{
    public AudioSource musicSourceA; // 배경음악 A를 위한 AudioSource
    public AudioSource musicSourceB; // 배경음악 B를 위한 AudioSource

    private bool isPlayingMusicB = false; // B 배경음악을 재생 중인지 여부
    private Vector3 lastPlayerPosition; // 이전 플레이어 위치
    private float fallDuration = 0f; // 플레이어가 떨어지고 있는 시간

    private void Start()
    {
        musicSourceA.enabled = true;
        musicSourceB.enabled = true;

        musicSourceA.Play(); // 게임 시작 시 배경음악 A를 재생
        lastPlayerPosition = transform.position; // 초기 플레이어 위치
    }

    private void Update()
    {
        Vector3 currentPlayerPosition = transform.position; // 현재 플레이어 위치
        float yPositionDifference = lastPlayerPosition.y - currentPlayerPosition.y;

        if (yPositionDifference > 0)
        {
            // 플레이어가 떨어지고 있는 상태인 경우
            fallDuration += Time.deltaTime; // 시간 측정

            if (fallDuration >= 1.5f && !isPlayingMusicB)
            {
                // 플레이어가 5초 이상 떨어지고 BGM이 재생 중이 아닌 경우
                isPlayingMusicB = true;
                musicSourceA.Stop();
                musicSourceB.Play();
            }
        }
        else
        {
            // 플레이어가 떨어지고 있지 않은 상태
            fallDuration = 0f; // 떨어지는 시간 초기화
        }

        // 플레이어 위치 업데이트
        lastPlayerPosition = currentPlayerPosition;

        // B음악이 종료된 경우 A음악으로 전환
        if (!musicSourceB.isPlaying && isPlayingMusicB)
        {
            isPlayingMusicB = false;
            musicSourceB.Stop();
            musicSourceA.Play();
        }
    }
}
