using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LOOKatObj : MonoBehaviour
{
    Transform target;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        transform.LookAt(target);
    }
}