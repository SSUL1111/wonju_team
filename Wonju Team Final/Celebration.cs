using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Celebration : MonoBehaviour
{
    public AudioSource audioSource; // ����� �ҽ�
    // Start is called before the first frame update
    void Start()
    {
        // ������� �������� üũ
        if (!audioSource.isPlaying)
        {
            // �� ��ȯ
            SceneManager.LoadScene("B");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
