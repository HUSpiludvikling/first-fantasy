using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthEnemy : MonoBehaviour {
    float life = 100f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void GetRekt(float input) 
    {
        life = life - input;

        if (life<=0)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Points>().GetScore(5);
            GameObject.FindGameObjectWithTag("BattleManager").GetComponent<Timer>().StartTimer("loadstring");
            Destroy(gameObject);
        }
    }
}
