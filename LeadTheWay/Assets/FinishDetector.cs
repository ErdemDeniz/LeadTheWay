using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters;

public class FinishDetector : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}

	void OnCollisionEnter (Collision WheelCollider)
	{
		if(WheelCollider.gameObject.name == "Cube")
			SceneManager.LoadScene ("ikinciEkran");

	}


}
