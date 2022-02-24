using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
   
    
   
    public float rotateSpeed;
  


    void Update()
    {
        gameObject.transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);
    }
}

