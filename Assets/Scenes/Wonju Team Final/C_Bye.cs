using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Bye : MonoBehaviour
{
    public GameObject ByePrefab;
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
        if (timer >= 1.5f && isInstantiate == false) // 1.5�ʰ� ������
        {
            Instantiate(ByePrefab, transform.position + new Vector3(10.7f, 0.3f, 1), Quaternion.Euler(0, 0, -37)); // ������Ʈ ����
            timer = 0f; // Ÿ�̸� �ʱ�ȭ (�ʿ信 ����)
            isInstantiate = true;
        }
    }
}
