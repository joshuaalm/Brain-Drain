using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using HTC.UnityPlugin.Vive;

public class correctAnswer : MonoBehaviour {

	public GameObject Child;
	public GameObject Monster;
	public GameObject Panel;
	public GameObject Cube1;
	public GameObject Cube2;
	public GameObject Cube3;
	
		void OnTriggerEnter(Collider other)
		{
			//if (other.GetComponent<Camera>() || other.GetComponent<VivePoseTracker>())
			
		//{
				Debug.Log("Object entered " + other.gameObject.name);
				Child.SetActive(true);
				Monster.SetActive(false);
				Cube1.SetActive(false);
				Cube2.SetActive(false);
				Cube3.SetActive(false);
				Panel.SetActive(false);


			//}
			
		}
	}


