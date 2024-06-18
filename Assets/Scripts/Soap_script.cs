using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soap_script : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
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

    private void OnCollisionExit(Collision other)
    {
        var script_man = other.gameObject.GetComponent<script_man>();
        script_man.stato = "lavaggioEseguito";
    }
}
