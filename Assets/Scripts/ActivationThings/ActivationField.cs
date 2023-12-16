using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationField : GateActivator
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.collider.CompareTag("Player"))
        {
            GateActivate();
            activationSwitch();
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            GateDeactivate();
            activationSwitch();
        }
        
    }
}
