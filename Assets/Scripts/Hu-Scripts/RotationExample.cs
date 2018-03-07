using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationExample : MonoBehaviour {

    public Vector3 RotationVector;

	// Update is called once per frame
	void Update () {
        transform.Rotate(RotationVector);
	}
}
