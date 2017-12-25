using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ColoreGM : MonoBehaviour {

	public static ColoreGM instance;
	public GameObject player;
	public GameObject restartButton;

	public GameObject gameOverText;
	public bool gameOver = false;

	public GameObject quitButton;
	public Text colorItensText;
	public int points = 0;
	public GameObject gameOverImage;
	public int healthPoints = 3;

	public GameObject WonImage;
	public SphereCollider playercol;


	public AudioSource backgroundMusic;
	public AudioClip collectSFX;
	public AudioClip gameOverOverSFX;

	private TransparenceDynamic transDynamicscript;
	private Transparence transScript;


	void Awake ()
	{
		if (instance != this) {
			Destroy (instance);
		}

		if (instance == null) {
			instance = this;
		}
	}

	void Start(){
		playercol = GetComponent<SphereCollider> ();


	}



	void Update () {


	}

	public void BallDied(){
		
			gameOverImage.SetActive (true);
		colorItensText.enabled = false;
		AudioSource.PlayClipAtPoint (gameOverOverSFX, gameObject.transform.position);
		backgroundMusic.enabled = false;




		gameOver = true;
	
	}

	public void BallScored(){
		points  = points + 1;
		colorItensText.text = "Colors: " +  points.ToString ();
		backgroundMusic.volume -= 0.01f;
		AudioSource.PlayClipAtPoint (collectSFX, gameObject.transform.position);

		}

	public void LevelComplete(){
		WonImage.gameObject.SetActive(true);
		colorItensText.enabled = false;
		playercol.enabled = false;
	}
}
