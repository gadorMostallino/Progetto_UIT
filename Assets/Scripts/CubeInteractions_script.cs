using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInteractions_script : MonoBehaviour
{
    public bool collision1 = false;
    public GameObject cube; 
    
    
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
        if (other.gameObject.Equals(cube))
        {
            collision1 = true;
        }

    }
}
