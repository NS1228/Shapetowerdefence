using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piecoll : MonoBehaviour
{

   

    public GameObject VFX;

    private bool isCreated = false;

   

    private Transform target;

    public float speed = 10f;

    public float dmg;

    public void Seek(Transform _target)
    {
        target = _target;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



        

       


        }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            // Debug.Log("work?");
            collision.GetComponent<Enemymovement>().hhealth -= dmg;
            Instantiate(VFX, this.transform.position, this.transform.rotation);
            
            this.gameObject.SetActive(false);
           

            //this.gameObject.SetActive(false); 

         


        }

        if (collision.tag == "PIE")
        {
            Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }



    }


   


}

// target.position - transform.position;


