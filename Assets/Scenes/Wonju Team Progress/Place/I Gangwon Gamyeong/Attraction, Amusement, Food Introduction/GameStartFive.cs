using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStartFive : MonoBehaviour
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
    public void GameStart_Five_Button()
    {
        StartCoroutine(LoadSceneAfterDelay());
    }

    private IEnumerator LoadSceneAfterDelay()
    {
        //myAudio.Play(); // 소리 재생
        yield return new WaitForSeconds(1f); // 1초 대기
        SceneManager.LoadScene("Find Out2"); // 씬 로드
    }
}
