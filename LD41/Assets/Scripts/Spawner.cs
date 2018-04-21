using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject[] hazards;

	public float startTimeBtwSpanws;
	private float timeBtwSpawns;

	private float difficultyTimer;
	public float startDifficultyTimer;
	public float decrease;

	public float debutGame = 2f;

	void Update(){

		if(debutGame <= 0){
			if(timeBtwSpawns <= 0){
				int rand = Random.Range(0, hazards.Length);
				Instantiate(hazards[rand], transform.position, hazards[rand].transform.rotation);
				timeBtwSpawns = startTimeBtwSpanws;
			} else {
				timeBtwSpawns -= Time.deltaTime;
			}

			if(difficultyTimer <= 0){
				if(startTimeBtwSpanws > 0.6f){
					startTimeBtwSpanws -= decrease;
					difficultyTimer = startDifficultyTimer;
				}
			} else {
				difficultyTimer -= Time.deltaTime;
			}
		} else {
			debutGame -= Time.deltaTime;
		}

	
	}
}
