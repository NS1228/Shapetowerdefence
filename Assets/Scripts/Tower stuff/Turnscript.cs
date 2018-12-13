using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turnscript : MonoBehaviour
{

    private float speed = 1f;

    public bool _rotate = false;

    private GameObject Stop;

   private GameObject objtoturn;

    //  private GameObject Test;

    // public GameObject crosshair;

     void Start()
    {
        Stop = GameObject.FindGameObjectWithTag("stopper");
    }




    void Update()
    {
       

            //Debug.Log("Clicked");
            Vector2 pos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            RaycastHit2D hitInfo = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(pos), Vector2.zero);
        // RaycastHit2D can be either true or null, but has an implicit conversion to bool, so we can use it like this

      

        //Debug.Log(hitInfo.transform.gameObject.name);


        // Here you can check hitInfo to see which collider has been hit, and act appropriately

        if (_rotate)
            {
                this.transform.gameObject.transform.Rotate(new Vector3(0, 0, 1) * speed);
            }

        
            
        
         if (hitInfo == Stop)   
       {
            _rotate = false;
        }

       





       // Debug.Log(_rotate);


    }





    // Here you can check hitInfo to see which collider has been hit, and act appropriately.


    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "CH")
        {
            Debug.Log("Coll");
            _rotate = true;
        }

      
        







    }
}














    



        

        
    


   

