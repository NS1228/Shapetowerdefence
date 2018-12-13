using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveme : MonoBehaviour {

    private float speed = 1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


  public  void Tap ()
    {
        this.transform.parent.gameObject.transform.Rotate(new Vector3(0, 0, 100) * speed);
          Debug.Log("SOO DOES THIS WORK?");
    }
}
