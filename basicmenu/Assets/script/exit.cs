using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class exit : MonoBehaviour {

	// exit on button and key
	public void quit () {
        Application.Quit();

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
	}
	

}
