using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Nodetwo : MonoBehaviour {

    private GameObject thisobj;

    public Color hoverColor;

    private Renderer rend;
    private Color startColor;

    private GameObject turret;

    public GameObject sshoper;

    public TextMeshProUGUI cannotafford;

    private Animation anim;

    public GameObject panelforcoins;



    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        thisobj = this.gameObject;




        anim = cannotafford.GetComponent<Animation>();


    }

    void OnMouseDown()
    {
        if (turret != null)
        {
            Debug.Log("Can't build there!");


        }


        //if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began)



        if (sshoper.GetComponent<Shop>().coins >= 150)
        {
            GameObject buildthisturret = BuildManager.instance.Buildthisdiatower();
            turret = (GameObject)Instantiate(buildthisturret, transform.position, transform.rotation);
            thisobj.SetActive(false);
            sshoper.GetComponent<Shop>().coins -= 150;
            panelforcoins.SetActive(false);

        }
        else
        {
            panelforcoins.SetActive(true);
            anim.Play("dissappear anim");
            Debug.Log("can't afford");


        }


    }

    //Debug.Log("work");



    void OnMouseEnter()
    {
        rend.material.color = hoverColor;

    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }



}
