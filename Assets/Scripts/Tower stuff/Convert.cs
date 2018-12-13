using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Convert : MonoBehaviour
{ 

  private int minhealth = 1;
  private int maxhealth = 5;

    private int minspeed = 2;
    private int maxspeed = 5;
    


    void Start()
    {
        this.GetComponent<Enemymovement>().hhealth = Random.Range(minhealth, maxhealth);
        this.GetComponent<Enemymovement>().movespeed = Random.Range(minspeed, maxspeed);

    }


  

}


