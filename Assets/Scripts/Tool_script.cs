using System;
using System.Collections;
using System.Collections.Generic;
using MixedReality.Toolkit.SpatialManipulation;
using UnityEngine;
using System.Threading.Tasks;

public class Hook_script : MonoBehaviour
{
    public GameObject brain;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    async void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Nose"))
        {
            brain.SetActive(true);
        }
        
    }
    
}
