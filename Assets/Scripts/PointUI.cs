using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PointUI : MonoBehaviour {

    Text pointGrafik;
    PointCounter point;

	// Use this for initialization
	void Start ()
    {
        pointGrafik = GetComponent<Text>();
        point = GameObject.FindGameObjectWithTag("Player").GetComponent<PointCounter>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        pointGrafik.text = point.GetScore().ToString();
	}
}
