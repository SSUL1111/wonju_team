using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.Rendering.VirtualTexturing.Debugging;

public class GangwonGamyeongNext: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GangwonGamyeong_NextButton()
    {
        SceneManager.LoadScene("I_A_Attraction_Amusement_Food_Introduction");
    }
}