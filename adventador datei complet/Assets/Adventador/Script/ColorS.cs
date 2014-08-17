using UnityEngine;
//using UnityEditor;


public class ColorS : MonoBehaviour 
{

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Q))
		{	
			gameObject.renderer.material.color = Color.red;
		}

		if (Input.GetKeyDown (KeyCode.W))
		{	
			gameObject.renderer.material.color = Color.white;
		}

		if (Input.GetKeyDown (KeyCode.E))
		{	
			gameObject.renderer.material.color = Color.blue;
		}

		if (Input.GetKeyDown (KeyCode.R))
		{	
			gameObject.renderer.material.color = Color.black;
		}

		if (Input.GetKeyDown (KeyCode.T))
		{	
			gameObject.renderer.material.color = Color.cyan;
		}

		if (Input.GetKeyDown (KeyCode.Z))
		{	
			gameObject.renderer.material.color = Color.yellow;
		}

	}
	


}
