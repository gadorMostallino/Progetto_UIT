using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using MixedReality.Toolkit.SpatialManipulation;
using MixedReality.Toolkit.UX;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Soap_script : MonoBehaviour
{
    public GameObject man;
    public UnityEngine.UI.Slider progressBar;
    private float scaleIncrement = 0.006f;   
    private GameManager gameManager;
    private ParticleSystem particle;

    // Start is called before the first frame update
    void Start()
    {
       
        if (Man_script.currentState.Equals(Man_script.States.start)) 
        {
            gameObject.GetComponent<ObjectManipulator>().enabled = true;
        }
        
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        particle = GetComponent<ParticleSystem>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter(Collision other)
    { 
        if (other.gameObject.CompareTag("Man"))
        {
            particle.Play();
        }
    }
    

    void OnCollisionStay(Collision other)
    {
            if (GameObject.Find("ProgressBar") != null)
            {

                if (other.gameObject.CompareTag("Man")){
                    progressBar.value = progressBar.value + scaleIncrement;

                if (progressBar.value.Equals(1))
                {
                    man.GetComponent<AudioSource>().Play();
                    Man_script.ChangeState(Man_script.States.washed);
                    //await Task.Delay(500);
                    Destroy(GameObject.Find("CanvasProgressBar"));
                    gameManager.NextPanel(1);
                    var particle = GetComponent<ParticleSystem>();
                    particle.Stop();
                    Man_script.ChangeMaterial("clean", GameObject.Find("body"));
                }
            }
    }


        void OnCollisionExit(Collision other)
        {
            if (other.gameObject.CompareTag("Man"))
            {
                var particle = GetComponent<ParticleSystem>();
                particle.Stop();
            }
        }
    

    }
}