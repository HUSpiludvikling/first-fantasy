using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PJump : MonoBehaviour
{
    Rigidbody rb;
    Vector3 V3;
    public float High;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * High, ForceMode.Impulse);
        }
    }
}