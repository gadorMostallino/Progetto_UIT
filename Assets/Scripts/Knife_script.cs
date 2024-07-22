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

    public Material red;
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
        if (other.gameObject.CompareTag("Box1"))
        {
            box2.SetActive(true);
            box1.GetComponent<Renderer>().material = red;

        }
        if (other.gameObject.CompareTag("Box2"))
        {
            humanOrgans.SetActive(true);
            GameManager gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
            GameObject.Find("Step3Cubes").SetActive(false);
            gameManager.NextPanel(5);
            GameManager.SetPositionTools(this.gameObject);
        }
    
    }
    
    
}
