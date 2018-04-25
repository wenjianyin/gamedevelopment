using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car_piaoyi : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.DownArrow)&&Input.GetKeyDown(KeyCode.RightArrow))
        {
            for (float total_time = 0; total_time < 15; total_time += Time.deltaTime)
            {
                //this.transform.position += 1 * transform.forward;
               
                GetComponent<Rigidbody>().AddForce(0 * transform.forward, ForceMode.Force);
                //Vector3 chuizhi = Quaternion.Euler(transform.position *90) * transform.forward;
                //GetComponent<Rigidbody>().AddForce(1 * Vector3.left, ForceMode.Force);
            }
               
            // GetComponent<Rigidbody>().AddForce(forces);//, ForceMode.Force
        }
    }

}
