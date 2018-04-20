using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour{

    //protected bool paused;


    /*void OnClick()
    {
        Time.timeScale = 0;

    }*/
    //public int click_num;
    //public Button button;
    //GameObject pause_button = GetGameObject 
    public void OnClickStop()
    {
        
        Debug.Log("游戏暂停");
        Time.timeScale = 0;
        //button.enabled = false;
        //gameObject.SetActive(false);
        //GameObject continue_button = gameObject.GetComponentInChildren<Button>().gameObject;
        //continue_button.SetActive(true);
        //gameObject.;
        //GameObjec
    }
    private void Start()
    {
        //GameObject continue_button = gameObject.GetComponentInChildren<Button>().gameObject;
        //continue_button.SetActive(false);
    }
    private void Update()
    {
        /*if (Time.timeScale == 0)
        {
            gameObject.SetActive(false);
        }*/
    }
    /*public void OnClickContinue()
    {
        Debug.Log("游戏继续");
        Time.timeScale = 1.0f;

    }*/
    /*public void Click()
    {
        click_num++;
        if (click_num % 2 == 1)
        {
            Debug.Log("游戏暂停");
            Time.timeScale = 0;
        }
        else 
        {
                Debug.Log("游戏暂停");
                Time.timeScale = 0;
        }
    }*/
    /*void OnPauseGame()
        {
            paused = true;
        }*/

    /*void OnResumeGame()
    {
        paused = false;
    }*/

    /*void Update()
    {
        if (!paused)
        {
            // do movement  
        }
    }*/
}
