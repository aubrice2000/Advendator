
using UnityEngine;
//using UnityEditor;
using System.Collections;

public class Color4: MonoBehaviour {
	Color[] colors = new Color[]{  Color.white, Color.black   };
	int index = 0;
	
	void Update(){
		if (Input.GetKeyDown (KeyCode.R)){
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