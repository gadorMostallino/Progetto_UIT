using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrganVase_script : MonoBehaviour
{
    public GameObject vase;

    public GameObject topVase;

    public float moveDistance = -0.001f;
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
        if (other.gameObject.Equals(vase))
        {
            Destroy(gameObject);
            topVase.transform.position += new Vector3(0, moveDistance, 0);
            
            
        }

    }
}
