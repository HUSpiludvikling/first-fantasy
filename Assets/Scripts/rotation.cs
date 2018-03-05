using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour {

    public Vector3 Rotationvector;

	// Update is called once per frame
	void Update () {
        transform.Rotate(Rotationvector);
	}
}
