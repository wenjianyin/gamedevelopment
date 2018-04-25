using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car_speed_judge : MonoBehaviour {
    // Use this for initialization
    int flag;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider collider)
    {
        global_number.judge_flag1 = 1;
        //flag = 1;
    }
}
