using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubTeleport : MonoBehaviour {

	PortalScript ps;

	// Use this for initialization
	void Start () {
		ps = GetComponentInParent<PortalScript>();
	}
	
	private void OnTriggerEnter(Collider collision)
	{
		//Get top level parent.
		Transform target = collision.transform;
		while(target.parent != null)
		{
			target = target.parent;
		}
		
        //Kald swap på moder objektet.
		ps.Swap(this.gameObject, target.transform);
	}

}
