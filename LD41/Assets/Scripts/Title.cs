using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour {

	public float waitTime;
	public Animator puzzleAnim;

	void Start(){
		StartCoroutine(LoadMenu());
	}

	IEnumerator LoadMenu(){

		yield return new WaitForSeconds(waitTime);
		puzzleAnim.SetTrigger("In");
		yield return new WaitForSeconds(waitTime - 4);
		SceneManager.LoadScene("Intro");
	}
}
