
using UnityEngine;
//using UnityEditor;
using System.Collections;

public class Color2: MonoBehaviour {
	Color[] colors = new Color[]{Color.green, Color.red, Color.blue, Color.white, Color.black , Color.cyan,
		Color.yellow  };
	int index = 0;
	
	void Update(){
		if (Input.GetKeyDown (KeyCode.W)){
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
