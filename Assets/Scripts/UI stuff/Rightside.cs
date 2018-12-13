using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rightside : MonoBehaviour {


   void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "CH")
        {
            Debug.Log("TOUCH");
            other.gameObject.transform.position = new Vector3(-12.2f, other.gameObject.transform.position.y, 0.0f);
        }

        if (other.gameObject.tag == "bbullets")
        {
            Debug.Log("TOUCH");
            Destroy(other.gameObject);
        }
    }


}
