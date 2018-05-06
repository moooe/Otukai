﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public float speed = 3.0f;
	public float slidspeed = 3;

	Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent <Animator> ();

		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Vector3.forward * speed * Time.deltaTime;
		float pos_x = transform.position.x;
		if (Input.GetKey (KeyCode.LeftArrow)) {
			if (pos_x > -321.8f) {
				transform.position += Vector3.left * slidspeed * Time.deltaTime;
			}
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			if (pos_x < -314.5f) {
				transform.position += Vector3.right * slidspeed * Time.deltaTime;
			}
		}



		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			animator.SetBool ("JUMP", true);
			animator.SetBool ("JUMP", true);
		}
		if (Input.GetKeyUp (KeyCode.UpArrow)) {
			animator.SetBool ("JUMP", false);
			animator.SetBool ("RUN", true);
		}
		
	}
		
		
	
}
