using System;
using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.Events;
public class GateActivator : MonoBehaviour
{
    [SerializeField]
    Gate gate;


    public UnityEvent on_actions;

    public UnityEvent off_acitons;

    protected bool _activated = false;


    protected void activationSwitch()
    {
        if (_activated) _activated = false;
        else _activated = true;
    }
    public virtual void GateActivate()
    {
        if (_activated) on_actions.Invoke(); ;
        gate.GateOpen();

    }
    public virtual void GateDeactivate()
    {
        if (!_activated) off_acitons.Invoke() ;
        gate.GateClose();

    }
}
