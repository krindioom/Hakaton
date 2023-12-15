using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerObstacleVisitor : ObstacleVisitor
{
    private Rigidbody2D _rigidBody;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    public override void VisitRampObstacle(RampObstacle rampObstacle)
    {
        Debug.Log("rampVisited");
    }
}
