using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStartTwo : MonoBehaviour
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
    public void GameStart_Two_Button()
    {
        StartCoroutine(LoadSceneAfterDelay());
    }

    private IEnumerator LoadSceneAfterDelay()
    {
        //myAudio.Play(); // �Ҹ� ���
        yield return new WaitForSeconds(1f); // 1�� ���
        SceneManager.LoadScene("Quiz1"); // �� �ε�
    }
}
