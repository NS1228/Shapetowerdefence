using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ttowers")
        {
            Debug.Log("SHOULD NOT BE HERE");
            this.transform.parent.gameObject.SetActive(false);
        }
        
    }
}
