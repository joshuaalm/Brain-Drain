using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class changeSceneFromCanvas : MonoBehaviour
{
    public string scene;
    private Scene nextScene;

    public void SwitchScene()
    {
         SceneManager.LoadScene(scene);
        //SceneManager.SetActiveScene(nextScene);
    }
}