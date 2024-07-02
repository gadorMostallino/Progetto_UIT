using System;
using System.Collections;
using System.Collections.Generic;
using MixedReality.Toolkit.SpatialManipulation;
using Unity.VisualScripting;
using UnityEngine;

public class Knife_script : MonoBehaviour
{
    public  GameObject box1, box2;
    public GameObject humanOrgans;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        bool flag = false;
        if (other.gameObject.CompareTag("Box1"))
        {
            flag = true;
            box2.SetActive(true);

        }
        if (other.gameObject.CompareTag("Box2"))
        {
            humanOrgans.SetActive(true);
            GameObject.Find("Step3").SetActive(false);
        }
    
    }
    
    
}
