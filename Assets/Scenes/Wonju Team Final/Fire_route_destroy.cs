using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_route_destroy : MonoBehaviour
{
    public float lifespan = 3.0f; // ������Ʈ�� ������ �ð�

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ������Ʈ ���� �� ���� �ð� �� ��������� ����
        Destroy(gameObject, lifespan);
    }
}
