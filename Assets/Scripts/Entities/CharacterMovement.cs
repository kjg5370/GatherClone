using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private PlayerController _Controller;
    
    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _Controller = GetComponent<PlayerController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        _Controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction *= 5;
        _rigidbody.velocity = direction;
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

}
