using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public float lifespan = 1.0f; // ������Ʈ�� ������ �ð�
    // Start is called before the first frame update
    void Start()
    {
        // ������Ʈ ���� �� ���� �ð� �� ��������� ����
        Destroy(gameObject, lifespan);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
