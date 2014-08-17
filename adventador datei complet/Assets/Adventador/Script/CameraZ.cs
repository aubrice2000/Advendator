using UnityEngine;
using System.Collections;

public class CameraZ : MonoBehaviour
{
	public float distance;
	private float sensitivityDistance = -7.5f;
	private float damping = 1.5f;
	
	private Vector3 xdistance;
	private float moveSpeed = 0.5f ;
	public GameObject target = null;
	
	
	void Start ()
	{
		distance = 55f;
		distance = transform.localPosition.x;
	}
	void Update ()
	{
		
		if (target != null) 
		{
			transform.LookAt(target.transform);
		}
		
		
		
		if (Input.GetMouseButton(0))
		{
			
			transform.Translate(Vector3.right * -Input.GetAxis("Mouse X") * moveSpeed);
			transform.Translate(transform.right * -Input.GetAxis("Mouse X") * moveSpeed, Space.World);
		}
		
		
		
	}
	
}

