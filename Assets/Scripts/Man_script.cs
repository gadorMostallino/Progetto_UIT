using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Man_script : MonoBehaviour
{
    public enum States
    {
        start,
        washed,
        brainExtraction,
        vasesClosed,
        bendageDone,
        sarcophagusClosed
    };
    
    public static States currentState;
    public string state;
    

    // Start is called before the first frame update
    void Start()
    {
        currentState = States.start;
        
    }

    // Update is called once per frame
    void Update()
    {
        state = currentState.ToString();
    }

    public static void ChangeState(States newState)
    {
        currentState = newState;
    }

    public static void ChangeMaterial(String name, GameObject obj)
    {
        switch (name)
        {
            case "clean":
                Material clean = Resources.Load("CleanBody", typeof(Material)) as Material;
                obj.GetComponent<Renderer>().material = clean;
                break;
        }
    }
}