using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {

	public GameObject arrowPrefab;
	public Transform arrowSpawnRight;
	public Transform arrowSpawnLeft;
	public VRTK.VRTK_ControllerEvents controllerEventRight;
	public VRTK.VRTK_ControllerEvents controllerEventLeft;
	bool canFireLeft, canFireRight;
	private GameObject arrowRight;
	private GameObject arrowLeft;
	// Use this for initialization
	void Start () {
		canFireRight = true;
		canFireLeft = true;
		arrowRight = Instantiate (arrowPrefab, arrowSpawnRight);
		arrowLeft = Instantiate (arrowPrefab, arrowSpawnLeft);

	}
	
	// Update is called once per frame
	void Update () {

		if (controllerEventRight.triggerPressed && canFireRight) {

			arrowRight.transform.SetParent (null);
			fire (arrowSpawnRight,arrowRight);
			canFireRight = false;;

		} 

		else if (controllerEventLeft.triggerPressed&&canFireLeft) {

			fire (arrowSpawnLeft,arrowLeft);
			canFireLeft = false;
		}

		if (Input.GetKeyDown (KeyCode.R)) {

			arrowRight = Instantiate (arrowPrefab, arrowSpawnRight);
			canFireLeft = true;
			canFireRight = true;

		}
	}

		public void fire(Transform muzzle, GameObject arrow){


		arrow.GetComponent<Rigidbody> ().velocity = (muzzle.parent.forward) * 15.0f ;
		Debug.Log (arrow.GetComponent<Rigidbody> ().velocity);
		Debug.Log (muzzle.parent.forward);


	}
}
