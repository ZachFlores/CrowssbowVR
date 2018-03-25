using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {

	public GameObject arrowPrefab;
    public Transform arrowSpawn;
    public VRTK.VRTK_ControllerEvents controllerEvent;
    private bool canFire;
	private GameObject arrow;
    [SerializeField]
    private float timeBetweenShots;
    [SerializeField]
    private float arrowSpeed;
    private float countDownShots;
	// Use this for initialization
	void Start () {
		canFire = true;
		arrow = Instantiate (arrowPrefab, arrowSpawn);
        countDownShots = timeBetweenShots;
	}
	
	// Update is called once per frame
	void Update () {

		if (controllerEvent.triggerPressed && canFire) {

			arrow.transform.SetParent (null);
			fire (arrowSpawn,arrow);

		}

   

        if (!canFire) {

            countDownShots -= Time.deltaTime;
            if(countDownShots <= 0)
            {
               arrow = Instantiate(arrowPrefab, arrowSpawn);
                canFire = true;
                countDownShots = timeBetweenShots;
                Debug.Log(canFire);

            }

        }
	}

		public void fire(Transform muzzle, GameObject arrow){

       
		arrow.GetComponent<Rigidbody> ().velocity = (muzzle.parent.forward) * 10.0f ;
        canFire = false;
    }
}
