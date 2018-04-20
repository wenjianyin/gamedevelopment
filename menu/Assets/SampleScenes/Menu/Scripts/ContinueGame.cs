using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContinueGame : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
        //gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClickContinue()
    {
        Debug.Log("游戏继续");
        Time.timeScale = 1.0f;
        //gameObject.SetActive(false);
        //GameObject pause_button = gameObject.GetComponentInParent<Button>().gameObject;
        //pause_button.SetActive(true);
        //GetComponent<Button>

    }
}
