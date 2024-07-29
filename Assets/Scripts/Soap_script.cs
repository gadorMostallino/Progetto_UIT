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
    private float scaleIncrement = 0.05f; //da rimettere a 0.05f    
    private GameManager gameManager;
//ciao
    // Start is called before the first frame update
    void Start()
    {
       
        if (Man_script.currentState.Equals(Man_script.States.start)) 
        {
            gameObject.GetComponent<ObjectManipulator>().enabled = true;
        }
        
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    async void OnCollisionEnter(Collision other)
    {
        var particle = GetComponent<ParticleSystem>();
        if (other.gameObject.CompareTag("Man"))
        {
            particle.Play();

            if (GameObject.Find("ProgressBar") != null)
            {

                if (other.gameObject.CompareTag("Man")){
                    progressBar.value = progressBar.value + scaleIncrement;

                if (progressBar.value.Equals(1))
                {
                    Man_script.ChangeState(Man_script.States.washed);
                    await Task.Delay(500);
                    Destroy(GameObject.Find("CanvasProgressBar"));
                    GameObject.Find("Hook").GetComponent<ObjectManipulator>().enabled = true;
                    gameManager.NextPanel(1);
                    particle.Stop();
                }
            }
        }
        else
        {
            particle.Stop();
        }
        
    }
    }


    private void OnCollisionExit(Collision other)
    {
        
    }
    

}