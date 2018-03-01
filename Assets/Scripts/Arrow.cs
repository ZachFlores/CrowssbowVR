using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour {

	public Transform attachPoint;
	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){

		if (col.gameObject.CompareTag ("Enemy")) {

            Vector3 tempVelocity = rb.velocity;
			col.gameObject.GetComponent<Rigidbody> ().isKinematic = true;
			col.gameObject.GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.FreezeAll;
			col.gameObject.transform.parent = attachPoint;
			col.gameObject.tag = "Wall";
            rb.velocity = tempVelocity;

		}

		else if(col.gameObject.CompareTag("Wall")) {
		
			rb.velocity = new Vector3 (0, 0, 0);
			rb.constraints = RigidbodyConstraints.FreezeAll;

		}

	}
}
