using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

	public static GameControl instance;

	public GameObject gameOverText;
	public bool gameOver = false;

	public float scrollSpeed = -1.0f;

	// Use this for initialization
	void Awake () {
		if (instance == null) {
			instance = this;
		} else if (instance != this){
			Destroy (gameObject);
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		if (gameOver == true && Input.GetKeyDown (KeyCode.Space)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	
	}

	public void BirdDied(){
		gameOverText.SetActive (true);
		gameOver = true;
	}
}