using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	
	private Paddle paddle;
	private bool hasStarted = false;
	private bool hasLaunched = false;
	
	Vector3 ballToPaddleVector;
	
	// Use this for initialization
	void Start () {
	
		paddle = GameObject.FindObjectOfType <Paddle> ();
		ballToPaddleVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(!hasStarted)
			this.transform.position = paddle.transform.position + ballToPaddleVector;
		
		if(!hasLaunched) {
			if(Input.GetMouseButtonDown(0)) {
				print("mouse clicked");
				hasStarted = true;
				this.rigidbody2D.velocity = new Vector2(2f, 9f);
				hasLaunched = true;
			}
		}
	}
	
	void OnCollisionEnter2D(Collision2D collision) {
	
		Vector2 tweak = new Vector2(Random.Range(0f,0.2f),Random.Range(0f,0.2f));
		
		if(hasStarted) {
			audio.Play();
			rigidbody2D.velocity += tweak;
		}
	}
}
