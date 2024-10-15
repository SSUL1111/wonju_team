using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class G_A_Attraction_Amusement_Food_Button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GA_Attraction_Amusement_Food_Button()
    {
        SceneManager.LoadScene("G_A_Attraction_Amusement_Food_Introduction");
    }
}
