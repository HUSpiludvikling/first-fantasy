using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPowerUp : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider collision)
	{
		if(collision.tag == "Player" && collision.gameObject.GetComponent<Jump>() == null)
		{
			collision.gameObject.AddComponent<Jump>();
			Destroy(gameObject);
		}
		else if (collision.tag == "Player")
		{
			collision.GetComponent<Jump>().PowerAmp += 10f;
			Destroy(gameObject);
		}

		
	}

}
