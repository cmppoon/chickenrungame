using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;
	public float boostSpeed;
	public float jumpSpeed;
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	public bool isGrounded;
	public bool isDead;

	private Rigidbody2D myRigidbody;
	private Animator myAnime;

	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent<Rigidbody2D>();
		myAnime = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
		if (isDead == false) {
			isGrounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround);

			myRigidbody.velocity = new Vector2 (moveSpeed,myRigidbody.velocity.y);

			if (Input.GetAxisRaw ("Horizontal") > 0f) {
				myRigidbody.velocity = new Vector2 (boostSpeed, myRigidbody.velocity.y);
			}

			if (Input.GetButtonDown ("Jump") && isGrounded) {
				myRigidbody.velocity = new Vector2 (myRigidbody.velocity.x, jumpSpeed);
			}
			myAnime.SetBool ("Ground", isGrounded);

		}
	}
//	public void OnCollisionEnter2D(Collision other){
//		if (other.tag == "speedBoost") {
//			myRigidbody.velocity = new Vector2 (moveSpeed + 2f,myRigidbody.velocity.y);
//		}
//	}
}
