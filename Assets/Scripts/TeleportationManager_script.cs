using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportationManager_script : MonoBehaviour
{
    private GameObject XRrig;
    private GameObject mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.Find("Main Camera"); 
        XRrig = GameObject.Find("MRTK XR Rig"); 
        mainCamera.transform.localPosition = new Vector3((float)0.61, (float)-0.09, (float)-34.81);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // Teleportation function
    public void TeleportPlayer( )
    {
        XRrig.transform.localPosition = new Vector3((float)0.61, (float)0, (float)-20.33);
    }

    public void IngressoSala()
    {
        XRrig.transform.localPosition = new Vector3((float)0.61, (float)0.2, (float)1);

    }


}
