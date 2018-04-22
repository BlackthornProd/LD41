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
	public Animator scoreAnim;
	public Animator goldenFade;
	public float goldenWaitTime;
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


		if(score.score >= 100){
			scoreAnim.SetTrigger("Flashing");
			goldenFade.SetTrigger("FadeIn");
			if(goldenWaitTime <= 0){
				SceneManager.LoadScene("Win");
			} else {
				goldenWaitTime -= Time.deltaTime;
			}
		}

	}

}
