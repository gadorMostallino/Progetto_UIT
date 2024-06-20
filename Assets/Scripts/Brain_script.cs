using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using MixedReality.Toolkit.SpatialManipulation;
using UnityEngine;

public class Brain_script : MonoBehaviour
{
    public GameObject bucket;
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
        if (other.gameObject.CompareTag("Bucket"))
        {
            //Destroy(this.gameObject);
            //Fissare posizione del cervello all'interno del cesto
            this.transform.position = new Vector3((float)2.11599994, (float)0.217999995, (float)1.46599996);
            gameObject.GetComponent<ObjectManipulator>().enabled = false;
        }
    }
    
}
