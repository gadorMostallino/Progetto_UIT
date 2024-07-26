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
        cubeInteractionsScript = GameObject.Find("CuboMummia1").GetComponent<CubeInteractions_script>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.Equals(sarcofago))
        {
            checkCollisionBoxes();
        }
        
    }

    void checkCollisionBoxes()
    {
        if(cubeInteractionsScript.collision1)
        {
            SetPositionMummy();
        }
        
        else
        {
            cubeInteractionsScript.collision1 = false;
        }
    }

    void SetPositionMummy()
    {
        this.gameObject.transform.position = new Vector3((float)-2.78210521, (float)1.47165191, (float)4.95855808);
        this.gameObject.transform.rotation = Quaternion.Euler((float)359.137238,(float)117.773857,(float)303.645264);
        this.gameObject.GetComponent<ObjectManipulator>().enabled = false;
        GameManager gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        gameManager.NextPanel(10);
    }
}
