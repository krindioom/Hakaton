using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class GateActivator : MonoBehaviour
{
    [SerializeField]
    Gate gate;

    [SerializeField]
    Animator Activator_state;
    [SerializeField]
    private string On_state;
    [SerializeField]
    private string Off_state;

    protected bool _activated = false;


    protected void activationSwitch()
    {
        if (_activated) _activated = false;
        else _activated = true;
    }
    public virtual void GateActivate()
    {
        if (_activated) Activator_state.Play(On_state);
        gate.GateOpen();

    }
    public virtual void GateDeactivate()
    {
        if (!_activated) Activator_state.Play(Off_state);
        gate.GateClose();

    }
}
