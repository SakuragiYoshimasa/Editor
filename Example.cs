using UnityEngine;
using UnityEditor;

class Example  {
	[InitializeOnLoadMethod]
	static void Exp(){

		EditorApplication.hierarchyWindowItemOnGUI += OnGUI;

	}

	static void OnGUI(int instanceID,Rect selectionRect){

		var obj = EditorUtility.InstanceIDToObject (instanceID);
		var go = obj as GameObject;

		if(go == null){
			return;
		}

		var pos = selectionRect;
		pos.x = pos.xMax - 16;
		pos.width = 16;
		var newActive = GUI.Toggle (pos,go.activeSelf,string.Empty);
		go.SetActive (newActive);

	}
}
