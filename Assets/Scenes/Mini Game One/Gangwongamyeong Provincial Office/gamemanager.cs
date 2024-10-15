using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    public int totalDifferences = 3; // �� ���� ����
    private int foundDifferences = 0; // ã�� ���� ����
    public Text resultText; // ��� �ؽ�Ʈ (���� �¸� �� �޽��� ���)
    public string stamp;

    // ���̸� ã���� �� ȣ��Ǵ� �Լ�
    public void FoundDifference()
    {
        foundDifferences++;

        // ��� ���̸� ã���� ���� �¸� ó��
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
        SceneManager.LoadScene("A"); // ������ ������ ��ȯ
    }
}
