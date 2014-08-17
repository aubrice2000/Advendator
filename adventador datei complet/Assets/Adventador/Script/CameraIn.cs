using UnityEngine;
using System.Collections;

public class CameraIn : MonoBehaviour
{
	
	public float distance;
	private float sensitivityDistance = -7.5f;
	private float damping = 1.5f;
	private float min = -100;
	private float max = -2;
	private Vector3 xdistance;
	private float moveSpeed = 0.5f ;
	float timer = 0;
	float direction = 0.2f;
	
	
	void Start ()
	{
		distance = 55f;
		distance = transform.localPosition.y;
		
	}
	void Update ()
	{
		
		
		
		
		if (Input.GetMouseButton(0))
		{
			transform.Rotate(Vector3.right * -Input.GetAxis("Mouse Y") * moveSpeed);
			
			
			direction *= -1;
			transform.Rotate (new Vector3 (1*direction, -1* direction, 1* direction));
			
			
		}
		
		if (timer % 100 == 0)
			direction *= -1;
		transform.Rotate (new Vector3 (0, 1* direction, 0));
		timer++;
	}
	
}


