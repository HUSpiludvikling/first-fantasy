using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerwalk : MonoBehaviour {
    Rigidbody rb;
    Vector3 V3 = Vector3.zero;
    public float Speed;
    float x;
    float z;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        V3.x = x;
        V3.z = z;
        rb.AddForce(V3,ForceMode.Impulse);

        //rb.AddForce(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
	}
}
