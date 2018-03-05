using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{
	GameObject[] children = new GameObject[2];
	public float cooldown = 2f;
	float TimeStamp = 0f;
	bool Available = true;
	// Use this for initialization
	void Start()
	{
		children[0] = transform.GetChild(0).gameObject;
		children[1] = transform.GetChild(1).gameObject;

	}

    
	public void Swap(GameObject caller, Transform teleportie)
	{
        
		CheckTime();

		if (Available && caller == children[0])
		{
			SetTime();
			teleportie.transform.SetPositionAndRotation(children[1].transform.position, teleportie.rotation);
		}
		else if (Available && caller == children[1])
		{
			SetTime();
			teleportie.transform.SetPositionAndRotation(children[0].transform.position, teleportie.rotation);
		}
	}

    
	private void CheckTime()
	{
		if(!Available)
		{
			Available = TimeStamp + cooldown < Time.timeSinceLevelLoad;
		}
	}
    
	void SetTime()
	{
		Available = false;
		TimeStamp = Time.timeSinceLevelLoad;
	}
}

