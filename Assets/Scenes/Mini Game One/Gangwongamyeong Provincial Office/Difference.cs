using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difference : MonoBehaviour
{
    private bool isFound = false; // ���̸� ã�Ҵ��� ����
    public GameObject redCirclePrefab; // ���� �� �������� �Ҵ��� ����
    AudioSource aud;
    private void Start()
    {
        aud = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        if (!isFound)
        {
            // ���̸� ã���� �� ó��
            isFound = true;

            // ���� �Ŵ������� �˸�
            FindObjectOfType<gamemanager>().FoundDifference();

            // Ŭ���� ��ġ�� ���� ���� ����
            ShowRedCircle();
            aud.Play();
        }
    }

    // ���� ���� Ŭ���� ��ġ�� �����ϴ� �Լ�
    void ShowRedCircle()
    {
        if (redCirclePrefab != null)
        {
            // Ŭ���� ������Ʈ�� ��ġ�� ���� �� ����
            Instantiate(redCirclePrefab, transform.position, Quaternion.identity);
        }
    }
}
