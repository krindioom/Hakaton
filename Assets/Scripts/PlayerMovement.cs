using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [field: SerializeField]
    public float Speed { get; set; } = 5f;


    private Rigidbody2D _rigidbody;
    private float _xDirection = 0;


    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Move()
    {
        _xDirection = Input.GetAxis("Horizontal");

        _rigidbody.velocity = Vector2.right * _xDirection * Speed;
    }
}
