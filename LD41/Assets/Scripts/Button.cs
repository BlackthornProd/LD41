using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

	private SpriteRenderer rend;
	public Sprite opened;
	public Sprite closed;
	public GameObject bubble;
	public Animator bubbleAnim;

	void Start(){
		rend = GetComponent<SpriteRenderer>();

	}

	void OnMouseOver(){
		bubble.SetActive(true);
		rend.sprite = opened;
	}

	void OnMouseExit(){
		StartCoroutine(HideBubble());
		rend.sprite = closed;
	}

	IEnumerator HideBubble(){
		bubbleAnim.SetTrigger("Hide");
		yield return new WaitForSeconds(.5f);
		bubble.SetActive(false);
	}
}

