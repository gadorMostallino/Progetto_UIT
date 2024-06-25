using System;
using System.Collections;
using System.Collections.Generic;
using MixedReality.Toolkit.SpatialManipulation;
using UnityEngine;

public class Soap_script : MonoBehaviour
{
    public GameObject man;
    // Start is called before the first frame update
    void Start()
    {
        var script_man = man.gameObject.GetComponent<script_man>();
        if (script_man.state == "start") 
        {
            gameObject.GetComponent<ObjectManipulator>().enabled = true;
        }
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
        //script_man.state = "washDone";
        //gameObject.GetComponent<ObjectManipulator>().enabled = false;
    }
}
