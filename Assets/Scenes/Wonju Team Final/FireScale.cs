using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScale : MonoBehaviour
{
    public Vector2 sizeChange = new Vector2(50f, 50f); // ������ ũ��
    public float duration = 0.3f; // ũ�Ⱑ ������ �ð�

    private RectTransform rectTransform;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    private void Update()
    {
        // ������ �ӵ��� UI ��� ũ�⸦ ����
        rectTransform.sizeDelta += sizeChange * Time.deltaTime / duration;

        // ũ�Ⱑ ���� �̻��� �Ǹ� ���߱� (���ϴ� �������� ���� ����)
        if (rectTransform.sizeDelta.x > 1800f) // ��: �ִ� �ʺ� 1800
        {
            enabled = false; // ��ũ��Ʈ ��Ȱ��ȭ
        }
    }
}
