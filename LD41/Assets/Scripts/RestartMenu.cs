using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMenu : MonoBehaviour {

	public bool isRestart;
	public string sceneToLoad;
	public Animator puzzleAnim;
	private ScoreKeeping score;
	public GameObject scoreObject;
	private Animator anim;

	void Start(){
		anim = GetComponent<Animator>();
		score = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreKeeping>();	
	}

	void OnMouseOver(){

		anim.SetBool("isHovering", true);

		if(Input.GetMouseButtonDown(0) && score.score < 100){
			StartCoroutine(LoadScene());
			if(isRestart == false){
				sceneToLoad = "Menu";
			} else {
				sceneToLoad = "Game";
			}
		}
	}

	void OnMouseExit(){
		anim.SetBool("isHovering", false);
	}

	IEnumerator LoadScene(){
		scoreObject.SetActive(false);
		puzzleAnim.SetTrigger("In");
		yield return new WaitForSeconds(2f);
		SceneManager.LoadScene(sceneToLoad);
	}
}
