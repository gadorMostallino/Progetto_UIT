using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bendage_script : MonoBehaviour
{
    public GameObject cube2, cube3, cube4, cube5;
    public GameObject mummy;
    
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
        if (other.gameObject.CompareTag("Cube1"))
        {
            cube2.SetActive(true);

        }
        if (other.gameObject.CompareTag("Cube2"))
        {
            cube3.SetActive(true);
        }
        if (other.gameObject.CompareTag("Cube3"))
        {
            cube4.SetActive(true);
        }
        if (other.gameObject.CompareTag("Cube4"))
        {
            cube5.SetActive(true);
        }
        if (other.gameObject.CompareTag("Cube5"))
        {
            GameObject.Find("Step4").SetActive(false);
            GameObject.Find("Man").SetActive(false);
            mummy.SetActive(true);
            
        }

    }

    private void OnCollisionExit(Collision other)
    {
        
    }
}
