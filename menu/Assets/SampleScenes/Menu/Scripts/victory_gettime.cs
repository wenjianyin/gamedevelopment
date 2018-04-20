using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class victory_gettime : MonoBehaviour {

    public float car_time2;
   // car_gettime car_gettime1 = new car_gettime();
	// Use this for initialization
	void Start () {
        //car_time = PlayerPrefs.GetFloat("car_time",Time.time).ToString();
        car_time2 = global_number.car_time;
        
    }
    private void OnGUI()
    {
        GUI.Label(new Rect(3, 133, 160, 30), "时间：" + car_time2 + "秒！");
    }
    // Update is called once per frame
    void Update () {
        

    }
    /*public void OnServerInitialized()
    {
        print(GetComponent<Collider>().gameObject.name + ":" + Time.time);
    }*/

}
