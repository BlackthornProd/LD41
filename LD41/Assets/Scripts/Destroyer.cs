using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {

	public float lifeTime = 10f;

	private AudioSource source;
	public AudioClip[] clips;


	void Start(){
		source = GetComponent<AudioSource>();
		int rand = Random.Range(0, clips.Length);
		source.clip = clips[rand];
		Destroy(gameObject, lifeTime);
		source.Play();
	}


}
