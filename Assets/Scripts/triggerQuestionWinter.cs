using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triggerQuestionWinter : MonoBehaviour {

	public GameObject questionPanel;
	public GameObject answer1;
	public GameObject answer2;
	//public GameObject answer3;
	
	void OnTriggerEnter(Collider other)
	{
		if (other.GetComponent<Camera>())
		{
			Debug.Log("Object entered " + other.gameObject.name);
			questionPanel.SetActive(true);
			answer1.SetActive(true);
			answer2.SetActive(true);
			//answer3.SetActive(true);

		}
	}
}

