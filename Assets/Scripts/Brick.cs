using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public static int breakableCount = 0;

	public int maxHit;
	
	private int timesHit;	
	private LevelManager levelManager;
	
	void Start () {
		timesHit = 0;
		levelManager = GameObject.FindObjectOfType <LevelManager> ();
		breakableCount++;
		print (breakableCount);
	}
	
	void OnCollisionEnter2D (Collision2D collision) {
		timesHit ++;
		breakableCount--;
		levelManager.BrickDestroyed();
		print (breakableCount);
		if(timesHit >= maxHit) {
			Destroy (gameObject);
		}
	}
		
	//TODO To be removed
	void StimulateWin() {
		levelManager.LoadNextLevel();
	}

}
