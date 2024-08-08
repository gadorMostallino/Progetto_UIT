using System;
using System.Collections;
using System.Collections.Generic;
using MixedReality.Toolkit.SpatialManipulation;
using UnityEngine;
using System.Threading.Tasks;

public class Mummy_script : MonoBehaviour
{
    private CubeInteractions_script cubeInteractionsScript;
    public GameObject sarcofago;

    // Start is called before the first frame update
    void Start()
    {
        cubeInteractionsScript = GameObject.Find("CuboMummia1").GetComponent<CubeInteractions_script>();
        this.gameObject.GetComponent<ObjectManipulator>().enabled = false;

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

    async void SetPositionMummy()
    {
        //this.gameObject.transform.position = new Vector3((float)-1.71500003, (float)-0.233999997, (float)0.652999997);
        //this.gameObject.transform.rotation = Quaternion.Euler((float)275.230896, (float)173.820313, (float)310.322205);
        
        //new position mummy2
        this.gameObject.transform.position = new Vector3((float)-1.80999994, (float)0.0549999997, (float)-0.518000007);
        //new rotation mummy2
        this.gameObject.transform.rotation = Quaternion.Euler((float)275.230865, (float)229.651794, (float)310.322479);
        
        
        this.gameObject.GetComponent<ObjectManipulator>().enabled = false;
        GameManager gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        gameManager.NextPanel(10);
        
        await Task.Delay(500);
        GameObject topSarcophagus = GameObject.Find("top"); 
        topSarcophagus.GetComponent<Animator>().Play("ClosingSarcophagus");
        topSarcophagus.GetComponent<AudioSource>().Play();
    }
}
