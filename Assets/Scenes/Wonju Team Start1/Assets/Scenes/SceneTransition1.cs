using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition1 : MonoBehaviour
{
    public void StartBtn()
    {
        SceneManager.LoadScene("StationToBus"); 
    }
}
