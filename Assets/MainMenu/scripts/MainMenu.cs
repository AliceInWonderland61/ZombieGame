using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void Play()
    {
        SceneManager.LoadScene("SampleScene 2");
    }
   
   public void Quit() 
    {
        Application.Quit();
        Debug.Log("Player Has Quit the Game");
    }
   
}
