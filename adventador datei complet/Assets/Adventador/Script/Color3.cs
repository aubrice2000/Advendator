
using UnityEngine;
//using UnityEditor;
using System.Collections;

public class Color3: MonoBehaviour {
	Color[] colors = new Color[]{Color.green, Color.red,  Color.white, Color.black , Color.yellow , Color.blue};
	int index = 0;
	
	void Update(){
		if (Input.GetKeyDown (KeyCode.E)){
			SetColor(colors[index++]);
			index = index % colors.Length;
		}
	}
	
	void SetColor(Color color){
		Renderer[] rends = (Renderer[])transform.root.gameObject.GetComponentsInChildren<Renderer> ();
		//foreach (Renderer rend in rends) 

			foreach(Material mat in renderer.materials){
				mat.color = color;
			}

	}
}
