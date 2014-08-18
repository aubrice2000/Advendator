using UnityEngine;
using System.Collections;

public class clickInfo : MonoBehaviour
{
	
	// Use this for initialization
	private bool PopUp;
	public string Info;

	
	void OnMouseDown()
	{
	 PopUp =  true;
	}
	
	void DrawInfo()
	{
		Rect rect = new Rect (20,20, 1550, 20);
		Rect close = new Rect (1550,20,20,20);
		if (PopUp)
		{
			GUI.Box(rect, Info);
			if (GUI.Button(close,"X"))
			{
				PopUp = false;
			}
		}
	}
	
	void OnGUI()
	{
		DrawInfo();

	}
}
