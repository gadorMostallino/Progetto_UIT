using System.Collections;
using System.Collections.Generic;
using MixedReality.Toolkit.SpatialManipulation;
using UnityEngine;

public class OrganVase_script : MonoBehaviour
{
    public GameObject vase;
    public GameObject topVase;
    public static int count;
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
            Debug.Log(count);
            topVase.transform.localPosition = new Vector3(0, 0, 0);
            if (count == 4)
            {
                Debug.Log(Man_script.currentState.ToString());
                Man_script.ChangeState(Man_script.States.vasesClosed);
                GameObject.Find("BendageRoll").GetComponent<ObjectManipulator>().enabled = true;
            }
        }

    }
}
