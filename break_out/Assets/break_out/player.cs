using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
	bool rightbutton = false,leftbutton = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(/*(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))&& */transform.position.x < 3.4f && transform.position.x > -3.4f){
			//GetComponent<Rigidbody> ().AddForce (Input.GetAxisRaw ("Horizontal"), 0f, -1f * Input.GetAxisRaw ("Horizontal"), ForceMode.Impulse);
			transform.Translate(Input.GetAxisRaw ("Horizontal") * 0.1f, 0f, 0f);
			if (rightbutton) {
				transform.Translate (0.1f, 0f, 0f);
			}
			if (leftbutton) {
				transform.Translate (-0.1f, 0f, 0f);
			}

		}
		//hamidasanaaiyouni
		if (transform.position.x >= 3.4f) {
			transform.Translate (-0.1f, 0f, 0f);
		}
		if (transform.position.x <= -3.4f) {
			transform.Translate (0.1f, 0f, 0f);
		}
	}
	public void rightButton(){
		rightbutton = true;
	}
	public void leftButton(){
		leftbutton = true;
	}
	public void rightButtonUp(){
		rightbutton = false;
	}
	public void leftButtonUp(){
		leftbutton = false;
	}
}
