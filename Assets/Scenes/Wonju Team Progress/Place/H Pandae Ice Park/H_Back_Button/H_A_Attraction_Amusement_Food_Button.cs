using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class H_A_Attraction_Amusement_Food_Button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void HAAttraction_Amusement_Food_Button()
    {
        SceneManager.LoadScene("H_A_Attraction_Amusement_Food_Introduction");
    }
}
