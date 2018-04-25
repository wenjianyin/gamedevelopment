using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    


    void OnGUI()
    {
        //GUI.Box(new Rect(Screen.width / 3, Screen.height / 10, Screen.width / 3, Screen.height / 4), "");
        if (GUI.Button(new Rect(Screen.width / 7 * 3, Screen.height / 12 * 2, Screen.width / 7, Screen.height / 18), "New Game"))
        {

            SceneManager.LoadScene(1);



        }
        if (GUI.Button(new Rect(Screen.width / 7 * 3, Screen.height / 12 * 3, Screen.width / 7, Screen.height / 18), "About Game"))
        {
        }
        if (GUI.Button(new Rect(Screen.width / 7 * 3, Screen.height / 12 * 4, Screen.width / 7, Screen.height / 18), "End Game"))
        {
            Application.Quit();
        }
    }
}

