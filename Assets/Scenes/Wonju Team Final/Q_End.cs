using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q_End : MonoBehaviour
{
    //public AudioSource audioSource; //����� �ҽ�
    public GameObject Q_EndPrefab;
    private float timer = 0f;

    public bool isInstantiate = false;
    // Start is called before the first frame update
    void Start()
    {
        ////������� �������� üũ
        //if (!audioSource.isPlaying)
        //{
        //    // �� ��ȯ
        //    SceneManager.LoadScene("B");
        //}
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; // ��� �ð� ����
        if (timer >= 2.5f && isInstantiate == false) // 2.5�ʰ� ������
        {
            Instantiate(Q_EndPrefab, transform.position + new Vector3(25.0f, 1.0f, 0), Quaternion.Euler(0, 0, -45.0f)); // ������Ʈ ����
            timer = 0f; // Ÿ�̸� �ʱ�ȭ (�ʿ信 ����)
            isInstantiate = true;
        }
    }
}
