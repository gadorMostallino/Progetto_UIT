using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInteractions_script : MonoBehaviour
{

    public bool collision1 = false;
    public bool collision2 = false;

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
        Debug.Log("ONCOLLISION ENTER CUBEINTERACTIONS");
        Debug.Log(this.gameObject.name);
        if (other.gameObject.Equals(cube) && this.gameObject.Equals(GameObject.Find("CuboMummia1")))
        {
            collision1 = true;
            Debug.Log("Collision1: " + collision1);
        }
        
        
        if (other.gameObject.Equals(cube) && this.gameObject.Equals(GameObject.Find("CuboMummia2")))
        {
            collision2 = true;
            Debug.Log("Collision2: " + collision2);
        }

    }
}
