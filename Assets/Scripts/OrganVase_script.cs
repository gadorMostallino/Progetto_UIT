using System.Collections;
using System.Collections.Generic;
using MixedReality.Toolkit.SpatialManipulation;
using UnityEngine;

public class OrganVase_script : MonoBehaviour
{
    public GameObject vase;
    public GameObject topVase;
    public static int count;
    
    public AudioClip audioClip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.Equals(vase))
        {
            Destroy(gameObject);
            count++;
            topVase.transform.localPosition = new Vector3(0, 0, 0); 
            //play the audioclip
            AudioSource.PlayClipAtPoint(audioClip, transform.position);
            if (count == 4)
            {
                Man_script.ChangeState(Man_script.States.vasesClosed);
                GameManager gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
                gameManager.NextPanel(6);
            }
        }

    }
}
