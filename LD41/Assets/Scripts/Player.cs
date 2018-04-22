using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public GameObject flat;
	public GameObject down;
	public GameObject up;

	public bool isDown;
	public bool isFlat;

	void Update(){

		if(Input.GetKey(KeyCode.LeftArrow)){
			flat.SetActive(false);
			down.SetActive(true);
			up.SetActive(false);

			isDown = true;
			isFlat = false;

		} else if(Input.GetKey(KeyCode.RightArrow)){
			flat.SetActive(false);
			down.SetActive(false);
			up.SetActive(true);

			isDown = false;
			isFlat = false;

		} else {
			flat.SetActive(true);
			down.SetActive(false);
			up.SetActive(false);

			isFlat = true;
		}
	}
}
