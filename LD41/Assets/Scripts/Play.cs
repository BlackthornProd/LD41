using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour {

	public Animator puzzleAnim;

	void OnMouseOver(){

		if(Input.GetMouseButtonDown(0)){
			StartCoroutine(LoadGame());
		}
	}

	IEnumerator LoadGame(){
		puzzleAnim.SetTrigger("In");
		yield return new WaitForSeconds(2f);
		SceneManager.LoadScene("Game");
	}
}
