using UnityEngine;
using System.Collections;

public class CubeMovement  : MonoBehaviour
{
	public float speed = 2;
	void Update()
	{
		transform.position = new Vector3(Mathf.PingPong(Time.time*speed, 4), transform.position.y, transform.position.z);
	}

}