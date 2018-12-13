using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamepause : MonoBehaviour
{

    public GameObject enemyinfo;
    public GameObject towerinfo;

    public  GameObject camera1;
    public GameObject camera2;



    // Use this for initialization
    void Start()
    {

        

    }

    // Update is called once per frame
    void Update()
    {

        

        if (towerinfo.activeInHierarchy || enemyinfo.activeInHierarchy)
        {
            Time.timeScale = 0;
            camera1.SetActive(false);
            camera2.SetActive(true);

        }
        else
        {
            Time.timeScale = 1;
            // camera2.enabled = !camera2.enabled;
            //camera1.enabled = camera1.enabled;
            camera1.SetActive(true);
            camera2.SetActive(false);
        }


      



    }
}
