using UnityEngine;

public class BGMController : MonoBehaviour
{
    public AudioSource musicSourceA; // ������� A�� ���� AudioSource
    public AudioSource musicSourceB; // ������� B�� ���� AudioSource

    private bool isPlayingMusicB = false; // B ��������� ��� ������ ����
    private Vector3 lastPlayerPosition; // ���� �÷��̾� ��ġ
    private float fallDuration = 0f; // �÷��̾ �������� �ִ� �ð�

    private void Start()
    {
        musicSourceA.enabled = true;
        musicSourceB.enabled = true;

        musicSourceA.Play(); // ���� ���� �� ������� A�� ���
        lastPlayerPosition = transform.position; // �ʱ� �÷��̾� ��ġ
    }

    private void Update()
    {
        Vector3 currentPlayerPosition = transform.position; // ���� �÷��̾� ��ġ
        float yPositionDifference = lastPlayerPosition.y - currentPlayerPosition.y;

        if (yPositionDifference > 0)
        {
            // �÷��̾ �������� �ִ� ������ ���
            fallDuration += Time.deltaTime; // �ð� ����

            if (fallDuration >= 1.5f && !isPlayingMusicB)
            {
                // �÷��̾ 5�� �̻� �������� BGM�� ��� ���� �ƴ� ���
                isPlayingMusicB = true;
                musicSourceA.Stop();
                musicSourceB.Play();
            }
        }
        else
        {
            // �÷��̾ �������� ���� ���� ����
            fallDuration = 0f; // �������� �ð� �ʱ�ȭ
        }

        // �÷��̾� ��ġ ������Ʈ
        lastPlayerPosition = currentPlayerPosition;

        // B������ ����� ��� A�������� ��ȯ
        if (!musicSourceB.isPlaying && isPlayingMusicB)
        {
            isPlayingMusicB = false;
            musicSourceB.Stop();
            musicSourceA.Play();
        }
    }
}
