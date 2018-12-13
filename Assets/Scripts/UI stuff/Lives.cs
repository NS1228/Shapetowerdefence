using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Lives : MonoBehaviour {

    public int lLives = 10;
    public GameObject livecount;
   // public GameObject enemy;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(lLives == 0)
        {
            SceneManager.LoadScene("level1");
           

        }

       // livecount.GetComponent<TextMeshProUGUI>().text = "Lives:" + livecount.ToString();
      //  Debug.Log(lLives);

    }

     void OnTriggerEnter2D(Collider2D collision)
    {
     if(gameObject.tag == "Enemy")
        {
            lLives -= 1;
            
        }
    }
}
