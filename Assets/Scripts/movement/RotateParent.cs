using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateParent : MonoBehaviour
{

    public float rotationSpeed = 1f;
    private float rotZ;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        rotZ += -Time.deltaTime * rotationSpeed;
        transform.rotation = Quaternion.Euler(0,0,rotZ);
    }
}
