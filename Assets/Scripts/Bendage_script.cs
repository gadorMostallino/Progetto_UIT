using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bendage_script : MonoBehaviour
{
    public GameObject cube1, cube2, cube3, cube4, cube5;
    public GameObject mummy;
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
        if (other.gameObject.CompareTag("Cube1"))
        {
            //cube change color to red when collision happens
            cube1.GetComponent<Renderer>().material = red;
            cube2.SetActive(true);

        }
        if (other.gameObject.CompareTag("Cube2"))
        {
            cube2.GetComponent<Renderer>().material = red;
            cube3.SetActive(true);
        }
        if (other.gameObject.CompareTag("Cube3"))
        {
            cube3.GetComponent<Renderer>().material = red;
            cube4.SetActive(true);
        }
        if (other.gameObject.CompareTag("Cube4"))
        {
            cube4.GetComponent<Renderer>().material = red;
            cube5.SetActive(true);
        }
        if (other.gameObject.CompareTag("Cube5"))
        {
            GameObject.Find("Step4Cubes").SetActive(false);
            GameObject.Find("Man").SetActive(false);
            mummy.SetActive(true);
            Man_script.ChangeState(Man_script.States.bendageDone);
            GameManager gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
            gameManager.NextPanel(8);
        }

    }

    private void OnCollisionExit(Collision other)
    {
        
    }
}
