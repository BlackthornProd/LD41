using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hazard : MonoBehaviour {

	public float speed;
	public bool isDown;

	public GameObject effect;
	private Animator camAnim;
	public GameObject ultimateEffect;
	private Animator cracks;
	private GM gm;

	private SpriteRenderer rend;
	public Color[] colors;
	private ScoreKeeping scoreKeeping;


	void Start(){
		scoreKeeping = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreKeeping>();
		gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GM>();
		rend = GetComponent<SpriteRenderer>();
		cracks = GameObject.FindGameObjectWithTag("Cracks").GetComponent<Animator>();
		camAnim = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();

		int randColor = Random.Range(0, colors.Length);
		rend.color = colors[randColor];
	}

	void Update(){
		transform.Translate(Vector2.left * speed * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D other){


		if(other.GetComponent<Player>().isFlat == true){
			
			Instantiate(ultimateEffect, transform.position, Quaternion.identity);
			Destroy(other.gameObject);
			Lose();
			camAnim.SetTrigger("MegaShake");
			Destroy(this.gameObject);
		}

		if(other.GetComponent<Player>().isDown != isDown){
			Instantiate(ultimateEffect, transform.position, Quaternion.identity);
			Destroy(other.gameObject);
			Lose();
			camAnim.SetTrigger("MegaShake");
			Destroy(this.gameObject);
		} else if(other.GetComponent<Player>().isDown == isDown) {
			Instantiate(effect, transform.position, Quaternion.identity);
			camAnim.SetTrigger("Shake");
			scoreKeeping.score++;
			gm.GetComponent<Score>().Anim();
			Destroy(gameObject);

		}
	}


	void Lose(){
		cracks.SetTrigger("Crack");
		gm.Lost();
	}

}
