using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationField : GateActivator
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GateActivate();
        activationSwitch();
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        GateDeactivate();
        activationSwitch();
    }
}
