using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoticeOne : MonoBehaviour
{
    //public AudioSource audioSource; //����� �ҽ�
    public GameObject NoticePrefab;
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
        if (timer >= 2f && isInstantiate == false) // 2�ʰ� ������
        {
            Instantiate(NoticePrefab, transform.position + new Vector3(25.0f, 1.0f, 0), Quaternion.Euler(0, 0, -45.0f)); // ������Ʈ ����
            timer = 0f; // Ÿ�̸� �ʱ�ȭ (�ʿ信 ����)
            isInstantiate = true;
        }
    }
}
