using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class URL_Two : MonoBehaviour
{
    public Button youtubeButtonTwo; // ��Ʃ�� ��ư�� ������ ����
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void YoutubeURL_Two()
    {
        Application.OpenURL("https://youtu.be/5sWXmkwIqa0?si=Ms_ZBy_c_GgASbHe");
    }
}
