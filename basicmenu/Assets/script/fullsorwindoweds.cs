using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class fullsorwindoweds : MonoBehaviour {
    public GameObject screentext;
    string fs= "Fullscreen";
    string ws= "Windowed";
    private resolution getx;
    private resolution gety;
    int z = 2;
    public bool change ;
    //screentext.GetComponent<Text>().text = ws;
   
    public void screen (string chscreen) {
        //x and y from resolution
        getx = GetComponent<resolution>();
        gety = GetComponent<resolution>();

        //fullscreen or windowed
        switch (z)
        {
            case 1:
                change = false;
                Screen.SetResolution(getx.x, gety.y, change);
                screentext.GetComponent<Text>().text = "Click to:"+fs;
                
                z = 2;
                break;
            case 2:
                change = true;
                Screen.SetResolution(getx.x, gety.y, change);
                screentext.GetComponent<Text>().text ="Click to:" + ws;
                
                z = 1;
                break;

        }
        
    }
}
