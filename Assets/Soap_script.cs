using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soap_script : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Soap script started");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Entered collision with " + other.gameObject.name);
        var particle = GetComponent<ParticleSystem>();
        if (other.gameObject.CompareTag("Man"))
        {
            //start particle system
            
            particle.Play();
            
        }
        else
        {
            particle.Stop();
        }
        
    }
}
