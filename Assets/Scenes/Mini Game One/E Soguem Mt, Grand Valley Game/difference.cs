using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class difference : MonoBehaviour
{
    private bool isFound = false;
    public GameObject redCirclePrefab;
    AudioSource aud;
    void Start()
    {
        // ������Ʈ�� ������ AudioSource ������Ʈ ��������
        aud = GetComponent<AudioSource>();
    }
    void OnMouseDown()
    {
        if (!isFound)
        {
            // Ŭ���ϸ� ���̸� ã�� ������ ó��
            isFound = true;
            FindObjectOfType<Gamemanager>().FoundDifference(); // ���� �Ŵ������� �˸�
            ShowRedCircle();
            aud.Play();
        }
    }
    void ShowRedCircle()
    {
        if (redCirclePrefab != null)
        {
            // Ŭ���� ������Ʈ�� ��ġ�� ���� �� ����
            Instantiate(redCirclePrefab, transform.position, Quaternion.identity);
        }
    }
}
