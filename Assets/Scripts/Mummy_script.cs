using System;
using System.Collections;
using System.Collections.Generic;
using MixedReality.Toolkit.SpatialManipulation;
using UnityEngine;

public class Mummy_script : MonoBehaviour
{

    private CubeInteractions_script cubeInteractionsScript;
    public GameObject sarcofago;
    
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
        Debug.Log("entrato in oncollisionenter della MUMMIA");
        if(other.Equals(sarcofago))
        {
            Debug.Log("Collisione con sarcofago");
            checkCollisionBoxes();
        }
        
    }

    void checkCollisionBoxes()
    {
        if(cubeInteractionsScript.collision1 && cubeInteractionsScript.collision2)
        {
            SetPositionMummy();
        }
        else
        {
            cubeInteractionsScript.collision1 = false;
            cubeInteractionsScript.collision2 = false;
        }
    }

    void SetPositionMummy()
    {
        Debug.Log("SetPositionMummy");
        this.gameObject.transform.position = new Vector3((float)-2.78210521, (float)1.47165191, (float)4.95855808);
        this.gameObject.transform.rotation = Quaternion.Euler((float)359.137238,(float)117.773857,(float)303.645264);
        this.gameObject.GetComponent<ObjectManipulator>().enabled = false;
    }
}
