﻿using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 PaddlePos = new Vector3 (0.5f, this.transform.position.y, 0f);
		
		float mousePosInBlock = Input.mousePosition.x / Screen.width * 16; 
		
		PaddlePos.x = Mathf.Clamp(mousePosInBlock, 0.5f, 15.5f);
		
		this.transform.position = PaddlePos;
	}
}
