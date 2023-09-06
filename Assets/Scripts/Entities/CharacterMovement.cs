using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private PlayerController _Controller;

    private Animator anim;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _Controller = GetComponent<PlayerController>();
        _rigidbody = GetComponent<Rigidbody2D>();
        anim = transform.GetChild(0).GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        _Controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        if (!gameManager.I.isMoveBlocked)
        {
            ApplyMovement(_movementDirection);
            if (_movementDirection != Vector2.zero) anim.SetBool("Move", true);
            else anim.SetBool("Move", false);
        }
        else
        {
            ApplyMovement(Vector2.zero);
            anim.SetBool("Move", false);
        }
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
