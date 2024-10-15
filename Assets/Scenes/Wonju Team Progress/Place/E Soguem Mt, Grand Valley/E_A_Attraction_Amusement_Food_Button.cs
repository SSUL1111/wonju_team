using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class E_A_Attraction_Amusement_Food_Button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Attraction_Amusement_Food_Button()
    {
        SceneManager.LoadScene("E_A_Attraction_Amusement_Food_Introduction");
    }
}
