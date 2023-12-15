using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvents : MonoBehaviour
{
    public event EventHandler<OnTouchEventArgs> OnSurfaceTouch;
    public event EventHandler<OnTouchEventArgs> OnSlidingTouch;
    public event EventHandler<OnTouchEventArgs> OnPowerFieldTouch;

    public event EventHandler<OnTouchEventArgs> OnSurfaceUnTouch;
    public event EventHandler<OnTouchEventArgs> OnSlidingUnTouch;
    public event EventHandler<OnTouchEventArgs> OnPowerFieldUnTouch;

    public event EventHandler<OnActiovationEventArgs> OnActivationEnter;
    



    public class OnTouchEventArgs : EventArgs
    {
        public Collision2D _collision;
        public Quaternion _rotation;
    }

    public class OnActiovationEventArgs : EventArgs
    {
        public Collision2D _collision;
        public GateActivator _gateActivator;
    }


}
