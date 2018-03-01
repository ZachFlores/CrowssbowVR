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

		
			if(navAgent.enabled != false)
			    navAgent.SetDestination (playerTransform.position);

            


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Arrow"))
        {
            gameObject.transform.parent = other.gameObject.transform.GetChild(0).transform;
            navAgent.enabled = false;
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }

        
    }
}


 
