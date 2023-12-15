using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Animator Gate_state;
    [SerializeField]
    private string Open_state;
    [SerializeField]
    private string Close_state;

    private bool _state = false;


    private void Start()
    {
       
    }

    public virtual void GateOpen()
    {
        Gate_state.Play(Open_state);
        _state = true;

    }
    public virtual void GateClose()
    {
        Gate_state.Play(Close_state);
        _state = false;
    }
    public bool GetGateState()
    {
        return _state;
    }
}
