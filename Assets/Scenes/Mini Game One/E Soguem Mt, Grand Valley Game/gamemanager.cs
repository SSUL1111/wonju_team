using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    public int totalDifferences = 3; // �� ���� ����
    private int foundDifferences = 0; // ã�� ���� ����
    public Text resultText;
    public string stamp;
    public void FoundDifference()
    {
        foundDifferences++;

        // ��� ���̸� ã���� �¸�
        if (foundDifferences >= totalDifferences)
        {
            GameWon();
        }
    }

    // ���� �¸� ó��
    private void GameWon()
    {
        resultText.text = "�����մϴ�! ��� ���̸� ã�ҽ��ϴ�!";
        Invoke("LoadNextScene", 3f);
    }
    private void LoadNextScene()
    {
        SceneManager.LoadScene("stamp"); // ������ ������ ��ȯ
    }
}
