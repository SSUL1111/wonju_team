using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Qtwo : MonoBehaviour
{
    public GameObject Q2Prefab;
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
        if (timer >= 1.0f && isInstantiate == false) // 1�ʰ� ������
        {
            Instantiate(Q2Prefab, transform.position + new Vector3(305.4965f, 362.3429f, 0), Quaternion.Euler(0, 0, 0)); // ������Ʈ ����
            timer = 0f; // Ÿ�̸� �ʱ�ȭ (�ʿ信 ����)
            isInstantiate = true;
        }
        
    }
}
