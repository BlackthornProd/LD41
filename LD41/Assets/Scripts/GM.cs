using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour {

	private ScoreKeeping scoreKeeping;

	void Start(){
		scoreKeeping = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreKeeping>();
		scoreKeeping.score = 0;
	}

	public void Lost(){
		StartCoroutine(LostProcedure());
	}

	public IEnumerator LostProcedure(){
		yield return new WaitForSeconds(5f);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		
	}

}
