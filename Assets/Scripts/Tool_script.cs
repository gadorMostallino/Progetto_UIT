using System;
using System.Collections;
using System.Collections.Generic;
using MixedReality.Toolkit.SpatialManipulation;
using UnityEngine;

public class Tool_script : MonoBehaviour
{
    public GameObject brain;
    public GameObject man;
    // Start is called before the first frame update
    void Start()
    {
        var script_man = man.gameObject.GetComponent<Man_script>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Nose"))
        {
            brain.SetActive(true);
        }
        
    }
    
    private void OnCollisionExit(Collision other)
    {
        //var script_man = other.gameObject.GetComponent<script_man>();
        //script_man.state = "brainGone";
    }
}
