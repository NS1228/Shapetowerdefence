using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour {


    public static BuildManager instance;



   

    void Awake()
    {
        if (instance !=null)
        {
            Debug.LogError("more than one BuildMnager in scene!");
                return;
        }
        instance = this;

        turretToBuild = standardTurretPrefab;
        buildthisturret = Diatower;
        buildthisturretthree = Rhomtower;
        buildthisturretfour = Kitetower;
        buildthisturretfive = Hearttower;
        buildthisturretsix = Pentatower;

        
    }

    public GameObject standardTurretPrefab;
    public GameObject Diatower;
    public GameObject Rhomtower;
    public GameObject Kitetower;
    public GameObject Hearttower;
    public GameObject Pentatower;
    

    void start ()
    {
       
    }

    private GameObject turretToBuild;
    private GameObject buildthisturret;
    private GameObject buildthisturretthree;
    private GameObject buildthisturretfour;
    private GameObject buildthisturretfive;
    public GameObject  buildthisturretsix;

    public GameObject GetTurretToBuild ()
    {
        return turretToBuild;
    }

    public GameObject Buildthisdiatower ()
    {
        return buildthisturret;
    }

    public GameObject BuildthisRhomtower ()
    {
        return buildthisturretthree;
    }

    public GameObject BuildthisKitetower ()
    {
        return buildthisturretfour;
    }

    public GameObject BuildthisHearttower ()
    {
        return buildthisturretfive;
    }

    public GameObject BuildthisPentatower()
    {
        return buildthisturretsix;
    }



    public void SetTurrettoBuild ()
    {
        
    }

    

}
