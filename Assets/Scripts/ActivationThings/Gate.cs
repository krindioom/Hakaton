using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Gate : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    UnityEvent Open_state;
    [SerializeField]
    UnityEvent Close_state;


    private bool _state = false;




    public virtual void GateOpen()
    {
        Open_state.Invoke() ;
        _state = true;

    }
    public virtual void GateClose()
    {
        Close_state.Invoke();
        _state = false;
    }
    public bool GetGateState()
    {
        return _state;
    }
}
