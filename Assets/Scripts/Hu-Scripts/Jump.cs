using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {
	Rigidbody rb;
	public float PowerAmp = 10f;
    Vector3 V3;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(V3, ForceMode.Impulse);
        }
		if(Input.GetButtonDown("Fire1")) 
		{
			RaycastHit[] rharray = Physics.RaycastAll(transform.position, Vector3.down, 1.1f);
			foreach (RaycastHit item in rharray)
			{
				if(!item.transform.GetComponent<Collider>().isTrigger)
				{
					rb.AddForce(Vector3.up * PowerAmp, ForceMode.Impulse);
					break;
				}
			}
			
		}
	}

}
