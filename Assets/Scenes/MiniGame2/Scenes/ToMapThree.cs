using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMapThree : MonoBehaviour
{
    public AudioSource audioSource; // ����� �ҽ�


    void Update()
    {
        // ������� �������� üũ
        if (!audioSource.isPlaying)
        {
            // �� ��ȯ
            SceneManager.LoadScene("Pandae1");
        }
    }
}