using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class car_speed : MonoBehaviour {

    public float total_time = 0;
    public float drag = 0;
    public int flag1;
    
    car_speed_judge judge = new car_speed_judge();
    //flag1 =  car_speed_judge.flag2;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        flag1 = global_number.judge_flag1;
        //flag1 = judge.flag;
        if (flag1 == 1)
        {
            Vector3 forces = new Vector3(0.0f, 0.0f, 0.70f);
            //total_time += Time.deltaTime;
            for (total_time = 0; total_time < 15; total_time += Time.deltaTime)
            {
                //GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 10000);
                //Rigidbody = 0.0f;
                GetComponent<Rigidbody>().AddForce(forces,ForceMode.Acceleration);
                if (Input.GetKeyDown(KeyCode.LeftShift))
                {
                    
                    // GetComponent<Rigidbody>().AddForce(forces);//, ForceMode.Force
                }

                if (total_time >3){
                    global_number.judge_flag1 = 0;
                }
            }
            //var moment = setTimeout(1000)
            //flag1 = 0;
            //global_number.judge_flag1 = 0;
            
        }
	}

    private object setTimeout(int v1, int v2, object s)
    {
        throw new NotImplementedException();
    }
}