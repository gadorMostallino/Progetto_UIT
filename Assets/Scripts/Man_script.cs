using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Man_script : MonoBehaviour
{
    public enum States
    {
        start,
        washed,
        brainExtraction,
        vasesClosed,
        bendageDone,
        sarcophagusClosed,
        end
    };
    public static States currentState;
    public string state;
    
    // Start is called before the first frame update
    void Start()
    {
        currentState = States.start;
    }

    // Update is called once per frame
    void Update()
    {
        state = currentState.ToString();
    }

    public static void ChangeState(States newState)
    {
        currentState = newState;
        Debug.Log(currentState);
    }
}
