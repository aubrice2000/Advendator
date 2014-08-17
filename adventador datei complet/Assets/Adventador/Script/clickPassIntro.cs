using UnityEngine;

/// <summary>
/// Title screen script
/// </summary>
public class clickPassIntro : MonoBehaviour
{
	void OnGUI()
	{
		const int buttonWidth = 100;
		const int buttonHeight = 60;
		
		
		Rect buttonRect = new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			);
		
		
		if (GUI.Button (buttonRect, "Adventador"))
		{
			
			Application.LoadLevel ("Adventador");
		}
		
	}
}