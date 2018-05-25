using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class resolution : MonoBehaviour {
    public int x;
    public int y;
    int z = 1;
    public GameObject resolutionscreen;
    //to get component from other script
    private fullsorwindoweds screen;
    public void Start()
    {// x and y for text Resolution in option
        x = PlayerPrefs.GetInt("Xresolution");
        y = PlayerPrefs.GetInt("Yresolution");
        resolutionscreen.GetComponent<Text>().text = "Resolution: " + x + "X" + y;
    }
    public void click () {
        //getcomponent boolean
        screen = GetComponent<fullsorwindoweds>();
        //option for resolution
        switch(z)
        {
            case 1:
                x = 800;
                y = 600;
                Screen.SetResolution(x,y, screen.change);
                resolutionscreen.GetComponent<Text>().text = "Resolution: " + x + "X" + y;
                PlayerPrefs.SetInt("Xresolution", x);
                PlayerPrefs.SetInt("Yresolution", y);
                z = 2;
                break;
            case 2:
                x = 1024;
                y = 768;
                Screen.SetResolution(x, y, screen.change);
                resolutionscreen.GetComponent<Text>().text = "Resolution: " + x + "X" + y;
                PlayerPrefs.SetInt("Xresolution", x);
                PlayerPrefs.SetInt("Yresolution", y);
                z = 3;
                break;
            case 3:
                x = 1280;
                y = 720;
                Screen.SetResolution(x, y, screen.change);
                resolutionscreen.GetComponent<Text>().text = "Resolution: " + x + "X" + y;
                PlayerPrefs.SetInt("Xresolution", x);
                PlayerPrefs.SetInt("Yresolution", y);
                z = 4;
                break;
            case 4:
                x = 1920;
                y = 1080;
                Screen.SetResolution(x, y, screen.change);
                resolutionscreen.GetComponent<Text>().text = "Resolution: " + x + "X" + y;
                PlayerPrefs.SetInt("Xresolution", x);
                PlayerPrefs.SetInt("Yresolution", y);
                z = 1;
                break;
        }


	}
}
