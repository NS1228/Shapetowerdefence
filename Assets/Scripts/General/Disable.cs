using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disable : MonoBehaviour {

    public GameObject Sphere;
    public float SPEED = 30f;

   public void Trains ()
    {
        Debug.Log("TRAINS");
        Sphere.transform.position += transform.up * SPEED * Time.deltaTime;

    }


   
}
