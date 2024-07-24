using System;
using System.Collections;
using System.Collections.Generic;
using MixedReality.Toolkit.SpatialManipulation;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List <GameObject> panels;
    private int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void NextPanel(int index)
    {
        panels[index-1].SetActive(false);
        panels[index].SetActive(true);
    }

    //Funzione che si occupa di riposizionare gli strumenti dopo che sono stati utilizzati, nella posizione iniziale.
    // Inoltre, viene disattivato l'object manipulator. 
    public static void SetPositionTools(GameObject tool)
    {
        switch (tool.name)
        {
            case "Soap":
                tool.transform.localPosition = new Vector3((float)-2.07474256, (float)-0.3807652, (float)-1.93799996);
                tool.transform.rotation = Quaternion.Euler((float)-90, (float)0, (float)0);
                tool.GetComponent<ObjectManipulator>().enabled = false;
                break;
            case "Hook":
                tool.transform.localPosition = new Vector3((float)-1.4787426,(float)-1.49876511,(float)-1.551); 
                tool.transform.rotation = Quaternion.Euler((float)-180, (float)0, (float)0);
                tool.GetComponent<ObjectManipulator>().enabled = false;
                break;
            case "StoneKnife":
                tool.transform.localPosition = new Vector3((float)-1.99549997,(float)-0.331099987,(float)-1.31550002); 
                tool.transform.rotation = Quaternion.Euler((float)-180, (float)180, (float)-90);
                tool.GetComponent<ObjectManipulator>().enabled = false;
                break;
            case "BendageRoll":
                tool.transform.localPosition = new Vector3((float)-2.07775164,(float)-0.333765149,(float)-0.987349868);
                tool.transform.rotation = Quaternion.Euler((float)0, (float)90, (float)0);
                tool.GetComponent<ObjectManipulator>().enabled = false;
                break;
        }
    }
}
