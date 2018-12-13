using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatest : MonoBehaviour
{

    private float rotationZ = 0f;
   

    void lockedRotation()
    {
        
        rotationZ = Mathf.Clamp(rotationZ, -90, 90);

        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, -rotationZ);
    }
}
