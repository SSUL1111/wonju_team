using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q_EndBus : MonoBehaviour
{
    public GameObject EndBusPrefab;
    private float timer = 0f;

    public bool isInstantiate = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; // ��� �ð� ����
        if (timer >= 5.0f && isInstantiate == false) // 5�ʰ� ������
        {
            Instantiate(EndBusPrefab, transform.position + new Vector3(1, 0, 1), Quaternion.Euler(0, 0, 0)); // ������Ʈ ����
            timer = 0f; // Ÿ�̸� �ʱ�ȭ (�ʿ信 ����)
            isInstantiate = true;
        }
    }
}
