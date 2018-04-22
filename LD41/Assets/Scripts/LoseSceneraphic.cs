using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseSceneraphic : MonoBehaviour {

	private SpriteRenderer rend;

	public Sprite[] loseScenes;

	void Start(){
		rend = GetComponent<SpriteRenderer>();
		int rand = Random.Range(0, loseScenes.Length);
		rend.sprite = loseScenes[rand];
	}
}
