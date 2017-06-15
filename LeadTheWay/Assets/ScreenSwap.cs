using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScreenSwap : MonoBehaviour {
	private float timer = 10f;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < timer; i++) {
			if (timer == 10) {
				SceneManager.LoadScene ("Demo");
			}
		}
		
	}
	
	// Update is called once per frame
	void Update () {
	}
}