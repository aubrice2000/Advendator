using UnityEngine;
using System.Collections;

public class door1 : MonoBehaviour {
	
	public float speed = -1.0F;
	public float Cspeed = 1.0F;
	public Transform door;
	public Transform open;
	public Transform closed;
	bool closing = false;
	bool opening = false;
	
	void OnTriggerEnter (Collider target)
	{
		opening = true;
		closing = false;
	}
	
	void Update ()
	{
		Vector3 DoorOpen = new Vector3(0, open.transform.position.y, 0);
		Vector3 DoorClosed = new Vector3(0, closed.transform.position.y, 0);
		Vector3 DoorMoving = new Vector3(0, door.transform.position.y, 0);
		
		if (opening == true)
			transform.Translate(0, speed*Time.deltaTime, 0);
		
		if (DoorMoving.y < DoorOpen.y)
		{
			opening = false;
			closing = true;
			door.transform.position = new Vector3(door.transform.position.x, open.transform.position.y, door.transform.position.z);
		}
		
		if (closing == true)
			transform.Translate(0, Cspeed*Time.deltaTime, 0);
		
		if (DoorMoving.y > DoorClosed.y)
		{
			closing = false;
			door.transform.position = new Vector3(door.transform.position.x, closed.transform.position.y, door.transform.position.z);
		}
	}
}