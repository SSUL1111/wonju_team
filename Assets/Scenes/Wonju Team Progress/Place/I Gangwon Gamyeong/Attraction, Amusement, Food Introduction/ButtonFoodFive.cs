using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFoodFive : MonoBehaviour
{
    public AudioSource myAudio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Food_Five_Button()
    {
        StartCoroutine(LoadSceneAfterDelay());
    }

    private IEnumerator LoadSceneAfterDelay()
    {
        myAudio.Play(); // 소리 재생
        yield return new WaitForSeconds(3f); // 3초 대기
        SceneManager.LoadScene("I Gangwon Gamyeong Food"); // 씬 로드
    }
}
