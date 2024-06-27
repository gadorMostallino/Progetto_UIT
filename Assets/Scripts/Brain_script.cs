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
            //Fix position inside the bucket once the interaction is done and disable the object manipulator.
            this.transform.position = new Vector3((float)-0.801, (float)0.143999994, (float)1.78400004);
            gameObject.GetComponent<ObjectManipulator>().enabled = false;
        }
    }
    
}
