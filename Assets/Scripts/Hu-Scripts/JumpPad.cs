using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour {
    private Rigidbody playerReference;
    public float Delay;
    public float Force;
	// Use this for initialization

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            playerReference = other.gameObject.GetComponent<Rigidbody>(); 
            StartCoroutine(Jump(Delay));    
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" )
        {
            playerReference = null;
        }
    }

    IEnumerator Jump(float delay)
    {
        yield return new WaitForSeconds(Delay);
        if(playerReference != null)
        {
            playerReference.AddForce(new Vector3(0, Force, 0f), ForceMode.Impulse);
        }


    }


}
