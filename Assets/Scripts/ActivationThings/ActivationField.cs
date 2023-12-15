using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationField : GateActivator
{
    private void OnCollisionEnter()
    {
        GateActivate();
        activationSwitch();
    }
    private void OnCollisionExit()
    {
        GateDeactivate();
        activationSwitch();
    }
}
