using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class backtogamescene : MonoBehaviour {
    void Update() {
        //load scene:game on key
        if (Input.GetKeyDown(KeyCode.Escape))   
        Application.LoadLevel("game"); 

	}
	
	
}
