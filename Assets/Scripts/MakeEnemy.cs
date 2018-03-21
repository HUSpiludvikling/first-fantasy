using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class MakeEnemy : MonoBehaviour {

	[MenuItem("Assets/Create/Enemy")]
	public static void Create () {
        Enemy asset = ScriptableObject.CreateInstance<Enemy>();

        AssetDatabase.CreateAsset(asset, "Assets/Enemy.asset");
        AssetDatabase.SaveAssets();

        EditorUtility.FocusProjectWindow();

        Selection.activeObject = asset;
	}
	

}
