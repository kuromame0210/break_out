using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour {
	public GameObject meshtext;	
	public static int ten;
	TextMesh tm;
	// Use this for initialization
	void Start () {
		ten = 0;
		tm = meshtext.GetComponent<TextMesh> ();
	}
	
	// Update is called once per frame
	void Update () {
		tm.text = ten.ToString();

		if (ten == 400) {
		//	SceneManager.LoadScene ("Main");
			tm.text = "!!congratulations!!";
			tm.color = Color.red;
			tm.fontSize = 30;

		}
	}
}
