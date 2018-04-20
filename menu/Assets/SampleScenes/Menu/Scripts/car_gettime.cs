using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using Class global_number;

public class car_gettime : MonoBehaviour {

    public float car_time1;
    // Use this for initialization
    //global_number global1 = new global_number();

    void Start () {

        //print(collider.gameObject.name + ":" + Time.time);
        //car_time = PlayerPrefs.GetFloat("car_time", Time.time).ToString();
        //PlayerPrefs.SetFloat("car_float", float.Parse(car_time));
        //global1.ca = Time.timeSinceLevelLoad;
        
    }

    // Update is called once per frame
    void Update () {
        car_time1 = Time.timeSinceLevelLoad;
       
    }
    void OnGUI()
    {

        global_number.car_time = car_time1;
    }
    
}
