using UnityEngine;
using System.Collections;

public class LightFollows : MonoBehaviour {
	
	public GameObject target = null; 
	public bool turnArround =false; 
	
	// Use this for initialization
	void Start () 
	{ 
		
	} 
	
	// Update is called once per frame 
	void Update () 
	{
		
		if (target != null) 
			
		{
			
			transform.LookAt(target.transform);
			
		} 
		
		if (turnArround)
		{
			
			transform.RotateAround(target.transform.position, Vector3.up, Time.deltaTime*5); 
			
		} 
		
	} 
	
}