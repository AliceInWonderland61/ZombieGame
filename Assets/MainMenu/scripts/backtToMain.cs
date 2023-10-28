using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backtToMain : MonoBehaviour
{
     public void PlayMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
   
}
