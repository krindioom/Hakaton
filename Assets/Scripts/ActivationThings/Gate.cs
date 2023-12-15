using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Animation Close_state;
    [SerializeField]
    Animation Open_state;


    private bool _state = false;


    private void Start()
    {
       
    }

    public virtual void GateOpen()
    {
        Open_state.Play();
        _state = true;

    }
    public virtual void GateClose()
    {
        Close_state.Play();
        _state = false;
    }
    public bool GetGateState()
    {
        return _state;
    }
}
