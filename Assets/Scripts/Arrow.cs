﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour {

	public Transform attachPoint;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col){

        if (col.gameObject.CompareTag("Enemy"))
        {

            GetComponent<Collider>().enabled = false;
        }
	}
}
