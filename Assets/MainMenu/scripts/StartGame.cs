using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // The name of the scene that we want to switch to
    public string sampleGameSceneName = "SampleScene2";

    // This method is called when the button is clicked
    public void OnClick()
    {
        // Load the sample game scene
        SceneManager.LoadScene(sampleGameSceneName);
    }
}
