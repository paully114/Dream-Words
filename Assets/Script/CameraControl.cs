using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject target;   
    
    private void Start()
    {
        
    }

    private void LateUpdate()
    {
        transform.LookAt(target.transform);
    }

   
}
