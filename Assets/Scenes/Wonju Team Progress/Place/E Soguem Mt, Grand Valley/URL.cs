 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class URL : MonoBehaviour
{
    public Button youtubeButton; // ��Ʃ�� ��ư�� ������ ����

    // Start is called before the first frame update
    void Start()
    {
        // ��ư�� Ŭ�� �̺�Ʈ�� YoutubeURL �޼��带 �߰�
        //if (youtubeButton != null)
        //{
        //    youtubeButton.onClick.AddListener(YoutubeURL);
        //}
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void YoutubeURL()
    {
        Application.OpenURL("https://youtu.be/l4Sc_E0GqcA?si=hNpVYu23ZC9N8VP5");
    }
}
