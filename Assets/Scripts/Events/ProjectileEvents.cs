using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static TriggerEvents;

public class ProjectileEvents : MonoBehaviour
{
    public delegate void OnSurfaceProjectileHit(object sender, Collision2D collision);
    public event OnSurfaceProjectileHit OnSurfaceHit;




}   
