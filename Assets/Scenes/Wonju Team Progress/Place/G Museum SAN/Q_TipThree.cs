using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q_TipThree : MonoBehaviour
{
    //public AudioSource audioSource; //����� �ҽ�
    public GameObject Q_TipOnePrefab;
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
        if (timer >= 12f && isInstantiate == false) // 12�ʰ� ������
        {
            Instantiate(Q_TipOnePrefab, transform.position + new Vector3(25.0f, 2.0f, 0), Quaternion.Euler(0, 0, -45.0f)); // ������Ʈ ����
            timer = 0f; // Ÿ�̸� �ʱ�ȭ (�ʿ信 ����)
            isInstantiate = true;
        }
    }
}
