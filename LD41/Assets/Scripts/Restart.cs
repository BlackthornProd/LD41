using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour {


	public Animator puzzleTransition;
	public float waitTime;
	public Text scoreDisplay;
	private ScoreKeeping score;

	public GameObject scoreObject;
	float waitTimeTwo = 1f;
	bool isActive;

	void Start(){
		score = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreKeeping>();	
		scoreDisplay.text = ""+ score.score;
	}
	
	void Update(){

		if(waitTimeTwo <= 0){
			if(isActive == false){
				scoreObject.SetActive(true);
				isActive = true;
			} 

		} else {
			waitTimeTwo -= Time.deltaTime;		
		}
		

		if(Input.anyKey && waitTime <= 0){
			StartCoroutine(RestartGame());
		} else {
			waitTime -= Time.deltaTime;
		}
	}

	IEnumerator RestartGame(){
		scoreObject.SetActive(false);
		puzzleTransition.SetTrigger("In");
		yield return new WaitForSeconds(2f);
		SceneManager.LoadScene("Game");
	}
}
