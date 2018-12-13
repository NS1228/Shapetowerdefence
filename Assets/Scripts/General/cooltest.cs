using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooltest : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ttowers")
        {
            Debug.Log("SHOULD NOT BE HERE");
            Destroy(this.gameObject);
        }
    }
}
