using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Topside : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "CH")
        {
            Debug.Log("TOUCH");
            other.gameObject.transform.position = new Vector3(other.gameObject.transform.position.x,-6.2f, 0.0f);
        }


        if (other.gameObject.tag == "bbullets")
        {
            Debug.Log("TOUCH");
            Destroy(other.gameObject);
        }
    }
}
