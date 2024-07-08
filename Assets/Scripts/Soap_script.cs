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
    public Image progressBar;
    public Dialog dialog;
    private float scaleIncrement = 0.15f; //da rimettere a 0.05f
    private float maxScale = 0.4089463f;
    
  

    // Start is called before the first frame update
    void Start()
    {
        if (Man_script.currentState.Equals(Man_script.States.start)) 
        {
            gameObject.GetComponent<ObjectManipulator>().enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    async void OnCollisionEnter(Collision other)
    {
        //Debug.Log("Entered collision with " + other.gameObject.name);
        var particle = GetComponent<ParticleSystem>();
        if (other.gameObject.CompareTag("Man"))
        {
            particle.Play();
            if (GameObject.Find("CanvasProgressBar") != null)
            {
                //Mathf.Clamp è una funzione di Unity che limita un valore all'interno di un intervallo specificato. Prende tre argomenti: il valore da limitare, il valore minimo e il valore massimo.
                float newScaleX = Mathf.Clamp(progressBar.rectTransform.localScale.x + scaleIncrement, 0, maxScale);
                progressBar.rectTransform.localScale = new Vector3(newScaleX, progressBar.rectTransform.localScale.y,
                    progressBar.rectTransform.localScale.z);
                if (newScaleX.Equals(maxScale))
                {
                    Man_script.ChangeState(Man_script.States.washed);
                    await Task.Delay(2500);
                    Destroy(GameObject.Find("CanvasProgressBar"));
                    GameObject.Find("Tool").GetComponent<ObjectManipulator>().enabled = true;
                    GameObject.Find("DialogStep1").SetActive(false);
                    dialog.gameObject.SetActive(true);
                }
            }
        }
        else
        {
            particle.Stop();
        }
        
    }

    private void OnCollisionExit(Collision other)
    {
        
    }
}
