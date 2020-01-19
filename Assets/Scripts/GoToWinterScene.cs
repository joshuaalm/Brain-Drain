using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToWinterScene : MonoBehaviour
{
    string winterSceneName = "BD_Winter_Scene";

    public void LoadWinterScene()
    {
        SceneManager.LoadScene(winterSceneName);
    }
}
