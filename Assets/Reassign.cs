using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reassign : MonoBehaviour {
    Text field;
	// Use this for initialization
	void Start () {
        field = GetComponent<Text>();
        GameObject.FindGameObjectWithTag("Player").GetComponent<Points>().Text = field;
        GameObject.FindGameObjectWithTag("Player").GetComponent<Points>().Update(); 
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
