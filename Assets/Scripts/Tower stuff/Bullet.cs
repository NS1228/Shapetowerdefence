using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour {


    public AudioClip impact;
    AudioSource audioSource;


    private Transform target;

    public float speed = 10f;

    public float dmg;

    public void Seek (Transform _target)
    {
        target = _target;
    }

	// Use this for initialization
	void Start () {


		
	}

    // Update is called once per frame
    void Update()
    {

        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = transform.TransformDirection(Vector3.up * 10);
        float distanceThisFrame = speed * Time.deltaTime;


        if (dir.magnitude <= distanceThisFrame)
        {
            //HitTarget();
            
            return;
            

        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
        audioSource.PlayOneShot(impact, 0.7F);


        //target.GetComponent<Enemymovement>().hhealth -= 1f;


    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
           // Debug.Log("work?");
            target.GetComponent<Enemymovement>().hhealth -= dmg;
            Destroy(this.gameObject);
           
        }


        if (collision.tag == "ttowers")
        {
            Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
    }

    //void HitTarget()
    //{
      //  Destroy(gameObject);
        
        
   // }
}

           // target.position - transform.position;