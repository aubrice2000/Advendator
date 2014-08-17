using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour {
	
	public Camera camera1;
	public Camera camera2;
	public Camera camera3;


	void Start () {
		camera1.enabled = true; 
		camera2.enabled = false;
		camera3.enabled = false;
	}
	
	void Update () {
		if (Input.GetKeyDown(KeyCode.D))
		{
			camera1.enabled = false;
			camera2.enabled = true;
			camera3.enabled = false;
		}
		if (Input.GetKeyDown(KeyCode.F))
		{
			camera1.enabled = true;
			camera2.enabled = false;
			camera3.enabled = false;
		}

		if (Input.GetKeyDown(KeyCode.G))
		{
			camera1.enabled = true;
			camera2.enabled = false;
			camera3.enabled = true;
		}
	}
}