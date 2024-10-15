 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class URL : MonoBehaviour
{
    public Button youtubeButton; // 유튜브 버튼을 연결할 변수

    // Start is called before the first frame update
    void Start()
    {
        // 버튼의 클릭 이벤트에 YoutubeURL 메서드를 추가
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
