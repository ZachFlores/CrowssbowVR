using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour {

	Transform playerTransform;
	NavMeshAgent navAgent;
	// Use this for initialization
	void Awake () {

		playerTransform = GameObject.FindGameObjectWithTag ("Player").transform;
		navAgent = GetComponent<NavMeshAgent> ();
        //test

	}
	
	// Update is called once per frame
	void Update () {

		if (gameObject.CompareTag ("Wall")) {

			navAgent.enabled = false;

		} 

		else {
			
			navAgent.SetDestination (playerTransform.position);

		}
	}
}
