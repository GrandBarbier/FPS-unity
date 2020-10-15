using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crossbow : MonoBehaviour
{
    public Camera camera;
    public Transform firePoint;
    public GameObject boltPrefab;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);

        if (Input.GetButton("Fire1"))
        {
            if (Physics.Raycast(ray, out hit))
            {
                Vector3 relativePos = hit.point - transform.position;
                
                Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.left);
                boltPrefab.transform.rotation = rotation;
                Instantiate(boltPrefab, firePoint.position, rotation);
            }
        }
        
         
    }

    
}
