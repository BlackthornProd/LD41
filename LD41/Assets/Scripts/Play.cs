using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour {

	public Animator puzzleAnim;
	private AudioSource source;
	public AudioClip clip;

	void Start(){
		source = GetComponent<AudioSource>();
	
	}


	void OnMouseOver(){

		if(Input.GetMouseButtonDown(0)){
			source.clip = clip;
			source.Play();
			StartCoroutine(LoadGame());
		}
	}

	IEnumerator LoadGame(){
		puzzleAnim.SetTrigger("In");
		yield return new WaitForSeconds(2f);
		SceneManager.LoadScene("Game");
	}
}
