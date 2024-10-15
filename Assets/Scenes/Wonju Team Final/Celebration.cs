using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Celebration : MonoBehaviour
{
    //public AudioSource audioSource; //����� �ҽ�
    public GameObject CelebrationInstantiatePrefab;
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
        if (timer >= 3.0f && isInstantiate == false) // 3�ʰ� ������
        {
            Instantiate(CelebrationInstantiatePrefab, transform.position + new Vector3(4.0f, 2.2f, 0), Quaternion.Euler(0,0,-40.0f)); // ������Ʈ ����
            timer = 0f; // Ÿ�̸� �ʱ�ȭ (�ʿ信 ����)
            isInstantiate = true;
        }
    }
}
