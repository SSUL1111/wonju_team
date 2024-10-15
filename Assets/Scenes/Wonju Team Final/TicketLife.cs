using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicketLife : MonoBehaviour
{
    public GameObject TicketPrefab;
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
        if (timer >= 3.0f && isInstantiate == false) // 3�ʰ� ������
        {
            Instantiate(TicketPrefab, transform.position + new Vector3(0, 0, 1), Quaternion.Euler(0, 0, 0)); // ������Ʈ ����
            timer = 0f; // Ÿ�̸� �ʱ�ȭ (�ʿ信 ����)
            isInstantiate = true;
        }
    }
}
