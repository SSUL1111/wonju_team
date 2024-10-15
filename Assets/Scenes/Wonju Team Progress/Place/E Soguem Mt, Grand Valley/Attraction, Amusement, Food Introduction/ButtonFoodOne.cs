using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFoodOne : MonoBehaviour
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
    public void FoodButton()
    {
        StartCoroutine(LoadSceneAfterDelay());
    }

    private IEnumerator LoadSceneAfterDelay()
    {
        myAudio.Play(); // �Ҹ� ���
        yield return new WaitForSeconds(3f); // 3�� ���
        SceneManager.LoadScene("E_D_Soguem Mt, Grand Valley Food"); // �� �ε�
    }
}
