using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkudDamage : MonoBehaviour {
    public int Damage = 10;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
       if (other.tag == "Enemy")
        {
            other.gameObject.GetComponent<HealthEnemy>().GetRekt(Damage);
            
        } 
    }
}
