using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fire_route : MonoBehaviour
{
    public GameObject FirePrefab;
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
            Instantiate(FirePrefab, transform.position + new Vector3(0, 0, 1), Quaternion.Euler(0, 0, 0)); // ������Ʈ ����
            timer = 0f; // Ÿ�̸� �ʱ�ȭ (�ʿ信 ����)
            isInstantiate = true;
        }
    }
}
