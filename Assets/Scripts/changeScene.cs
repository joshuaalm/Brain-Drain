using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class changeScene : MonoBehaviour
{

    public string loadScene;

    private void OnTriggerEnter(Collider other)
	{

        SceneManager.LoadScene(loadScene);

	}

}
