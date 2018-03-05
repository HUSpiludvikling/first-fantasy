using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spillerjump : MonoBehaviour {
    Rigidbody rb;
    Vector3 V3;
    public float high;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(V3 * high, ForceMode.Impulse);
        }
	}
}
