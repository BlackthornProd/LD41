using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {


	public Animator puzzleTransition;
	public float waitTime;
	
	void Update(){
		if(Input.anyKey && waitTime <= 0){
			StartCoroutine(RestartGame());
		} else {
			waitTime -= Time.deltaTime;
		}
	}

	IEnumerator RestartGame(){
		puzzleTransition.SetTrigger("In");
		yield return new WaitForSeconds(2f);
		SceneManager.LoadScene("Game");
	}
}
