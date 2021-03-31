using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Buttons : MonoBehaviour
{
public void GameStart()
{
    SceneManager.LoadScene("game");
}

public void settings()
{
    if(Input.GetKey("escape"))
    {
        SceneManager.LoadScene("SampleScene");
    }
}
}
