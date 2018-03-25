using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPlatform : MonoBehaviour {

    protected int enemyCount;

    [SerializeField]
    protected float moveDistance;

    protected virtual void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            enemyCount++;
            this.transform.position -= (transform.forward * moveDistance);
            Debug.Log(enemyCount);
        }
}
    }
