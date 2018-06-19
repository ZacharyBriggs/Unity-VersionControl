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
        Vector3 force = Vector3.up;
        Rigidbody rb3d = GetComponent<Rigidbody>();
		if(Input.GetKeyDown(KeyCode.Space))
        {
            rb3d.AddForce(force * 500);
        }
	}
}
