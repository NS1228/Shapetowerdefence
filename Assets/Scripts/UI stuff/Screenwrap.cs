using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screenwrap : MonoBehaviour
{

    float leftConstriant = Screen.width;
    float rightConstriant = Screen.width;
    float topConstriant = Screen.height;
    float bottomConstriant = Screen.height;
    float butter = 1.0f;
    Camera cam;
    float distancez;


    // Use this for initialization
    void Start () {

        cam = Camera.main;
        distancez = Mathf.Abs(cam.transform.position.z + transform.position.z);
        leftConstriant = cam.ScreenToWorldPoint(new Vector3(0.0f, 0.0f, distancez)).x;
        rightConstriant = cam.ScreenToWorldPoint(new Vector3(Screen.width, 0.0f, distancez)).x;
        bottomConstriant = cam.ScreenToWorldPoint(new Vector3(0.0f, 0.0f, distancez)).y;
        bottomConstriant = cam.ScreenToWorldPoint(new Vector3(0.0f, Screen.height, distancez)).y;



    }

    // Update is called once per frame
    private void FixedUpdate()
    {

        if(transform.position.x < leftConstriant - butter )
        {
            transform.position = new Vector3(rightConstriant - 0.10f, transform.position.y, transform.position.z);
        }

        if (transform.position.x > rightConstriant)
        {
            transform.position = new Vector3(rightConstriant, transform.position.y, transform.position.z);
        }

        if (transform.position.y < bottomConstriant - butter)
        {
            transform.position = new Vector3(transform.position.x, topConstriant + butter, transform.position.z);
        }

        if (transform.position.y > topConstriant - butter)
        {
            transform.position = new Vector3(transform.position.x,bottomConstriant - butter, transform.position.z);
        }

    }
   
}
