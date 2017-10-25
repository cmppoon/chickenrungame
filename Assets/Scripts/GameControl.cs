using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

	public static GameControl instance;

	public bool gameOver = false;
	public int powerGauge = 0;
	public float scrollSpeed = -5.0f;
	public GameObject gameOverText;
	public GameObject Coin;
	public Image guage;
	public Sprite guageFill_0;
	public Sprite guageFill_1;
	public Sprite guageFill_2;
	public Sprite guageFill_3;
	public PlayerController thePlayer;
	public Vector3 instantiatePosition;
	public float nextSpawnTime;

	void Awake () {
		if (instance == null) {
			instance = this;
		} else if (instance != this){
			Destroy (gameObject);
		}
	
	}

	// Use this for initialization
	void Start () {
		nextSpawnTime = Time.time + 2.0f;
		thePlayer = FindObjectOfType<PlayerController> ();
	}

	// Update is called once per frame
	void Update () {
		if (gameOver == true && Input.GetKeyDown (KeyCode.Space)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}

//		instantiatePosition = thePlayer.transform.position + new Vector3 (0.2f, 4f, 0f);
		InstantiatedCoin ();
			
	}

	void InstantiatedCoin(){
		if(Time.time > nextSpawnTime){
			//do stuff here (like instantiate)
			Instantiate(Coin, thePlayer.transform.position + new Vector3 (5f, 1f, 0f),thePlayer.transform.rotation);
			//increment next_spawn_time
			nextSpawnTime += 5.0f;
		}
	}

	public void BirdDied(){
		gameOverText.SetActive (true);
		gameOver = true;
	}

	public void AddGauge(int gaugeToAdd){
		if (powerGauge >= 3) {
			powerGauge = 3;
		}else if(powerGauge >= 3 && gaugeToAdd == -3){
			powerGauge += gaugeToAdd;
			UpdateGuage ();
		}
		else if(powerGauge < 3){
			powerGauge += gaugeToAdd;
			UpdateGuage ();
		}
	}

	public void UpdateGuage(){
		switch (powerGauge) {
		case 0:
			guage.sprite = guageFill_0;
			return;
		case 1:
			guage.sprite = guageFill_1;
			return;
		case 2:
			guage.sprite = guageFill_2;
			return;
		case 3:
			guage.sprite = guageFill_3;
			return;
		default:
			guage.sprite = guageFill_0;
			return;
		}
	}
}