using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collision_Script : MonoBehaviour
{
    public void Start()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Entered collision with " + other.gameObject.name);
        Destroy(other.gameObject);
    }
}
