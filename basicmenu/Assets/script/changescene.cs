using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour {
    
	//change scene
	public void change (string scena){
        Application.LoadLevel(scena);
	}
	
}
