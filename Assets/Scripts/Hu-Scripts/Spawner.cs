using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public float radius;
    public GameObject enemy;
    public float frequency;

	// Use this for initialization
	void Start () {
        StartCoroutine(Spawn(enemy, frequency));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Spawn(GameObject enemy,float nextSpawn)
    {
        yield return new WaitForSeconds(nextSpawn);
        var g= Instantiate(enemy, transform.position + (Vector3) Random.insideUnitCircle * radius, Quaternion.identity) as GameObject;
        g.transform.position = new Vector3(g.transform.position.x, 2, g.transform.position.z);
        if (nextSpawn > 0.1f)
        {
            nextSpawn = nextSpawn * 0.99f;
        }
        StartCoroutine(Spawn(enemy,nextSpawn));
    }
}
