using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour {

	public void Lost(){
		StartCoroutine(LostProcedure());
	}

	public IEnumerator LostProcedure(){
		yield return new WaitForSeconds(5f);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		
	}

}
