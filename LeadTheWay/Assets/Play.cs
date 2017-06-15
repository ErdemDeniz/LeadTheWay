using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour {

	public void loadScene(string sceneName)
	{
		Application.LoadLevel (sceneName);
	}
}