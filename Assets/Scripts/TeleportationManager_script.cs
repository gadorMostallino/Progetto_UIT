using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportationManager_script : MonoBehaviour
{

    

    // Start is called before the first frame update
    void Start()
    {
       GetComponent<Camera>().transform.localPosition = new Vector3((float)0.61, (float)-0.09, (float)-34.81);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // Teleportation function
    public void TeleportPlayer( )
    {
        GameObject camera = GameObject.Find("MRTK XR Rig");
        camera.transform.localPosition = new Vector3((float)0.61, (float)0, (float)-20.33);
        Debug.Log("teletrasporto");
    }

    public void IngressoSala()
    {
        GameObject camera = GameObject.Find("MRTK XR Rig");
        camera.transform.localPosition = new Vector3((float)0.61, (float)0.2, (float)1);
        Debug.Log("teletrasporto");

    }


}
