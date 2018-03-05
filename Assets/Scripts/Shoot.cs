using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public GameObject Bullet;
    public float Fart = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            //Skal lige have spurt om hvordan man får spiller til at kan skyde imens han hopper og løber.
            GameObject temp;
            temp = Instantiate(Bullet, transform.position, Quaternion.identity);
            temp.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * Fart,ForceMode.Impulse);
        }
	}
}
