using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG : MonoBehaviour {

	public float speed;

	void Start(){
		Destroy(gameObject, 15f);
	}

	void Update () {
		transform.Translate(Vector2.right * speed * Time.deltaTime);
	}
}
