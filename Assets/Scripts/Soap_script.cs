using System;
using System.Collections;
using System.Collections.Generic;
using MixedReality.Toolkit.SpatialManipulation;
using UnityEngine;
using UnityEngine.UI;

public class Soap_script : MonoBehaviour
{
    public GameObject man;

    public Image progressBar;
    private float scaleIncrement = 0.1f;
    private float maxScale = 0.4089463f;
  

    // Start is called before the first frame update
    void Start()
    {
        var script_man = man.gameObject.GetComponent<Man_script>();
        if (script_man.state == "start") 
        {
            gameObject.GetComponent<ObjectManipulator>().enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Entered collision with " + other.gameObject.name);
        var particle = GetComponent<ParticleSystem>();
        if (other.gameObject.CompareTag("Man"))
        {
            particle.Play();
            //Mathf.Clamp è una funzione di Unity che limita un valore all'interno di un intervallo specificato. Prende tre argomenti: il valore da limitare, il valore minimo e il valore massimo.
            float newScaleX = Mathf.Clamp(progressBar.rectTransform.localScale.x + scaleIncrement, 0, maxScale);
            progressBar.rectTransform.localScale = new Vector3(newScaleX, progressBar.rectTransform.localScale.y, progressBar.rectTransform.localScale.z);
        }
        else
        {
            particle.Stop();
        }
        
    }

    
}
