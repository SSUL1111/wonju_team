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
        timer += Time.deltaTime; // 경과 시간 증가
        if (timer >= 1.5f && isInstantiate == false) // 1.5초가 지나면
        {
            Instantiate(ByePrefab, transform.position + new Vector3(10.7f, 0.3f, 1), Quaternion.Euler(0, 0, -37)); // 오브젝트 생성
            timer = 0f; // 타이머 초기화 (필요에 따라)
            isInstantiate = true;
        }
    }
}
