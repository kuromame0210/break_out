using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))&& transform.position.x < 3.4f && transform.position.x > -3.4f){
			transform.Translate(Input.GetAxisRaw ("Horizontal") * 0.1f, 0f, 0f);
		}
		if (transform.position.x >= 3.4f) {
			transform.Translate (-0.1f, 0f, 0f);
		}
		if (transform.position.x <= -3.4f) {
			transform.Translate (0.1f, 0f, 0f);
		}
	}
}
