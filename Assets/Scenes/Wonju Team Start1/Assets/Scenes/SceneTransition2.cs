using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneTransition2 : MonoBehaviour
{
    public void NextStartBtn()
    {
        SceneManager.LoadScene("WonjuTourMap");
    }
    
}
