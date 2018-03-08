using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour {

	private Transform playerTransform;
	private NavMeshAgent navAgent;
    private bool impaled;
    private Animator anim;
    private Rigidbody rb;
    private Rigidbody rbParent;
    private GameObject impalingArrow;

    // Use this for initialization
    void Awake () {

        impaled = false;
		playerTransform = GameObject.FindGameObjectWithTag ("Player").transform;
		navAgent = GetComponent<NavMeshAgent> ();
        anim = GetComponentInChildren<Animator>();
        anim.SetBool("isDead", false);
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
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
            impalingArrow = other.gameObject;
            gameObject.transform.parent =impalingArrow.transform.GetChild(0).transform;
            navAgent.enabled = false;
            rb.constraints = RigidbodyConstraints.FreezeAll;
            rb.isKinematic = false;
            anim.SetBool("isDead", true);
            impaled = true;
            rbParent = impalingArrow.GetComponent<Rigidbody>();
        }

        else if (other.CompareTag("Player"))
        {

            Destroy(gameObject);
        }

        else if (impaled && other.CompareTag("Wall" ))
        {
            rbParent.constraints = RigidbodyConstraints.FreezeAll;
        }

        
    }
}


 
