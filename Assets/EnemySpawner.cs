using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    [SerializeField]
    private Transform[] spawnLocations;
    [SerializeField]
    private GameObject enemyPrefab;
	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnEnemy", 0, 2);
	}
	
	void SpawnEnemy()
    {
        int location = Random.Range(0, spawnLocations.Length);
        Instantiate(enemyPrefab,spawnLocations[location]);
    }
}
