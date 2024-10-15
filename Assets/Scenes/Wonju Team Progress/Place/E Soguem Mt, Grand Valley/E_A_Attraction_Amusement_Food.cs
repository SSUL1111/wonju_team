using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_A_Attraction_Amusement_Food : MonoBehaviour
{
    public GameObject AttractionAmusementFoodPrefab;
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
        if (timer >= 7f && isInstantiate == false) // 7�ʰ� ������
        {
            Instantiate(AttractionAmusementFoodPrefab, transform.position + new Vector3(5, 3, 1), Quaternion.Euler(0, 0, 0)); // ������Ʈ ����
            timer = 0f; // Ÿ�̸� �ʱ�ȭ (�ʿ信 ����)
            isInstantiate = true;
        }
    }
}
