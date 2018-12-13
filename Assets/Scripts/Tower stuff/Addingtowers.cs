using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Addingtowers : MonoBehaviour {

    public int speed = 10;
    public GameObject tower;

    public Canvas can;
    public Button place;


    // Use this for initialization
    void Start () {

       

    }
	
	// Update is called once per frame
	void Update () {

     

        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("leftclick");
            Instantiate(tower, place.transform.position, place.transform.rotation);
        }

    }

   
}


