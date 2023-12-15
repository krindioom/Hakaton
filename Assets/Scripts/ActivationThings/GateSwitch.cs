using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateSwitch : GateActivator
{
    

    private void OnCollisionEnter()
    {
        if (_activated)
        {
            GateActivate();
            activationSwitch();
        }
        else 
        {
            GateDeactivate();
            activationSwitch();
        }
    }

}
