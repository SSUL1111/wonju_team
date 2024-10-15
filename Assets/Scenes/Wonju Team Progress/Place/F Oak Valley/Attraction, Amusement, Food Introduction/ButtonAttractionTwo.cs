using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonAttractionTwo : MonoBehaviour
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
    public void AttractionTwo_Button()
    {
        StartCoroutine(LoadSceneAfterDelay());
    }

    private IEnumerator LoadSceneAfterDelay()
    {
        myAudio.Play(); // �Ҹ� ���
        yield return new WaitForSeconds(2.5f); // 2.5�� ���
        SceneManager.LoadScene("F_B_Oak Valley Attraction"); // �� �ε�
    }
}
