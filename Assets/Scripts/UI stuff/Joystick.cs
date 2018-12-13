using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joystick : MonoBehaviour {

    
    public Transform Crosshair;
    public float speed = 5.0f;
    public bool touchStart = false;
    private Vector2 pointA;
    private Vector2 pointB;

    public Transform Circle;
    public Transform outterlane;

    public GameObject trackpad;


   



    // Use this for initialization
    void Start () {

        
		
	}

    // Update is called once per frame
    void Update()
    {

        Vector2 pos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        RaycastHit2D hitInfo = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(pos), Vector2.zero);

       


       if (hitInfo == trackpad)
        {
            touchStart = true;
        }
        else
        {


           touchStart = false;
        }

        MoveCharacter(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));

        if (Input.GetMouseButtonDown(0))
        {
            pointA = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));

            // Circle.transform.position = pointA * 1;
            //outterlane.transform.position = pointA * 1;

        }
        if (Input.GetMouseButton(0))
        {
            // touchStart = true;
            pointB = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
        }
        else
        {
            // touchStart = false;
        }
    

	}

    private void FixedUpdate()
    {
        if(touchStart)
        {
            Vector2 offset = pointB - pointA;
            Vector2 direction = Vector2.ClampMagnitude(offset, 10.0f);
            MoveCharacter(direction * 1);


            //Circle.transform.position = new Vector2(pointA.x + direction.x, pointA.y + direction.y) * 1;
        }
    }


    void MoveCharacter(Vector2 direction)
    {
        if (Input.GetMouseButton(0))
        {
            Crosshair.Translate(direction * speed * Time.deltaTime);



        }
    }
}
