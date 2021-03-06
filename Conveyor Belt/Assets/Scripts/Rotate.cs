﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public AudioSource rotation;
   
    public float degreesPerSec;
    public bool Right = true;
  
    void Start()
    {
        rotation = GetComponent<AudioSource>();
    }

    void Update()
    {
        
        if (Right == true)
        {
            float rotAmount = -degreesPerSec * Time.deltaTime;
            float currentRot = transform.localRotation.eulerAngles.z;
            transform.localRotation = Quaternion.Euler(new Vector3(0, 0, (currentRot + rotAmount)));
        }
        else
        {
            float rotAmount = degreesPerSec * Time.deltaTime;
            float currentRot = transform.localRotation.eulerAngles.z;
            transform.localRotation = Quaternion.Euler(new Vector3(0, 0, (currentRot + rotAmount)));
        }
        
       
    }

}
