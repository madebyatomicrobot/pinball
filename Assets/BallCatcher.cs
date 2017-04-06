﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCatcher : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        col.transform.GetComponent<Rigidbody>().velocity = Vector3.zero;
        col.transform.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        col.transform.position = new Vector3(-0.15f, 0.6f, -1);
    }
}
