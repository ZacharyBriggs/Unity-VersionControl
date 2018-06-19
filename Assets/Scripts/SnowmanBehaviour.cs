using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowmanBehaviour : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 force;
        Rigidbody rb3d = GetComponent<Rigidbody>();
        if(Input.GetKey(KeyCode.W))
        {
            force = Vector3.forward;
            rb3d.AddForce(force * 100);
        }
		if(Input.GetKeyDown(KeyCode.Space))
        {
            force = Vector3.up;
            rb3d.AddForce(force * 500);
        }
	}
}
