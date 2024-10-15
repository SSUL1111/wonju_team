using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_Bus : MonoBehaviour
{
    public AudioClip audioClip; // ����� ����� Ŭ��
    private AudioSource audioSource;
    private float timer = 0f;
    private bool isAudioPlayed = false;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = audioClip;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isAudioPlayed)
        {
            timer += Time.deltaTime; // Ÿ�̸� ����

            if (timer >= 5.0f) // 5�ʰ� �����ٸ�
            {
                audioSource.Play(); // ����� ���
                isAudioPlayed = true; // ������� ����Ǿ����� ���
            }
        }
    }
}
