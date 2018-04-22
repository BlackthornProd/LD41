using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Text scoreDisplay;
	public Animator scoreAnim;
	private ScoreKeeping score;

	void Start(){
		score = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreKeeping>();
	}

	void Update(){
		
		scoreDisplay.text =score.score + "/100";
	
	}

	public void Anim(){
		scoreAnim.SetTrigger("Pop");
	}

}
