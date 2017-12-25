using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour {

	public void StartGame(){
		SceneManager.LoadScene (1);
	}

	public void Restart(){

		SceneManager.LoadScene (1);
	}

	public void BackToMenu(){

		SceneManager.LoadScene (0);
	}

	public void QuitGame(){
		Application.Quit ();
	}
}
