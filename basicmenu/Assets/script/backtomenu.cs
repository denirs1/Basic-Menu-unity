using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class backtomenu : MonoBehaviour {
	void Update () {
        //load scene:menu on key
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.LoadLevel("menu");
	}
}
