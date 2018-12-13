using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Newlives : MonoBehaviour {

   public  int newLives = 10;
    public GameObject livecount;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (newLives == 0)
        {
            SceneManager.LoadScene("level1");
        }
             
        //Debug.Log(newLives);
        livecount.GetComponent<TextMeshProUGUI>().text = "Lives:" + newLives.ToString();
    }

    
}
