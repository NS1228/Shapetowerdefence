using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Shop : MonoBehaviour {

    BuildManager buildmanager;

    public int coins;

    

  //  public TextMeshPro coinscounter;

    public TextMeshProUGUI coinscounter;

    void Start()
    {
       buildmanager = BuildManager.instance;
        
        
       
    }

    public void PurchaseStandardTurret()
    {
        
       // Debug.Log("Standard Turret Purchased");
       // buildmanager.SetTurrettoBuild(buildmanager.standardTurretPrefab);
    }

    public void PurchaseAnotherTurret()
    {
      //  Debug.Log("Standard Turret Purchased");
       // buildmanager.SetTurrettoBuild(buildmanager.anotherturretPrefab)
    }

     void Update()
    {
        coinscounter.GetComponent<TextMeshProUGUI>().text = "Coins:" + coins.ToString();
    }
}
