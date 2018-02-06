using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballscript : MonoBehaviour {
	public GameObject ball1;
	GameObject ball2;
	Vector3 startspeed = new Vector3 (8f, 0f, 8f);
	Vector3 startPos = new Vector3 (0f, 0.5f, 0f);

	// Use this for initialization
	void Start () {
		ball2 = Instantiate (ball1, startPos, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Jump") && ball2.transform.position == startPos) {
			ball2.GetComponent<Rigidbody> ().AddForce (startspeed, ForceMode.VelocityChange);
		}
		if (ball2.transform.position.z < -4) {
			Destroy (ball2.gameObject);
			ball2 = Instantiate (ball1, startPos, Quaternion.identity);
		}
	}
}
