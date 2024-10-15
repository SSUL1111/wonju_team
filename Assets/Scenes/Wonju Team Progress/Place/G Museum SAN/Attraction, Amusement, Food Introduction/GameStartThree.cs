using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStartThree : MonoBehaviour
{
    //public AudioSource myAudio;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GameStart_Three_Button()
    {
        StartCoroutine(LoadSceneAfterDelay());
    }

    private IEnumerator LoadSceneAfterDelay()
    {
        //myAudio.Play(); // 소리 재생
        yield return new WaitForSeconds(1f); // 1초 대기
        SceneManager.LoadScene("Quiz7"); // 씬 로드
    }
}
