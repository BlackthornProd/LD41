using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour {


	public SpriteRenderer rend;
	public Sprite[] story;
	private int index;
	public Animator storyAnim;

	private float waitTime = 1f;
	public Animator puzzleAnim;
	public string sceneName;

	void Start(){
		Cursor.visible = false;
	}

	void Update () {

		rend.sprite = story[index];

		if(waitTime <= 0){
			if(Input.anyKeyDown && index < story.Length - 1){

				storyAnim.SetTrigger("Change");
				index++;
			} else if(Input.anyKeyDown && index >= story.Length - 1){
				puzzleAnim.SetTrigger("In");
				StartCoroutine(LoadGame());
			}
		} else {
			waitTime -= Time.deltaTime;
		}

	}

	IEnumerator LoadGame(){
		yield return new WaitForSeconds(2f);
		SceneManager.LoadScene(sceneName);
	}
}
