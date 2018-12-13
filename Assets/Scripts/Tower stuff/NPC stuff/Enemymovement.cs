using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Enemymovement : MonoBehaviour
{

    public Image healthBar;

    public GameObject GM;

   public float  hhealth = 1f;
   private float health;
    public int reward = 10;

    

    public GameObject panel;

    [SerializeField]
    Transform[] waypoints;

    [SerializeField]
    public float movespeed = 2f;

    int waypointIndex = 0;

    

    void Start()
    {
        //transform.position = waypoints[waypointIndex].transform.position;
        health = hhealth;

    }

    // Use this for initialization


    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = hhealth / health;
        Debug.Log(healthBar.fillAmount);

        Move();

        if (hhealth <= 0f)
        {
            
           //this.gameObject.SetActive(false);
            Destroy(this.gameObject);
          panel.GetComponent<Shop>().coins += reward;

          
            
        }


       


    }

   public void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position,
                                               waypoints[waypointIndex].transform.position,
                                               movespeed * Time.deltaTime);

        if (transform.position == waypoints[waypointIndex].transform.position)
        {
            waypointIndex += 1;
        }

        if (waypointIndex == waypoints.Length)
        {
            this.gameObject.SetActive(false);

            GM.GetComponent<Newlives>().newLives -= 1;

        }
    }
}
