using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveForce;
    public float rotateAngle;
    public float maxSpeed;

    private Rigidbody2D head;

    private bool moveRight;
    private bool moveLeft;

	void Start ()
    {
        head = GetComponentInChildren<Rigidbody2D>();

	}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            moveLeft = true;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            moveRight = true;
        }
    }

    void FixedUpdate ()
    {
        Move();
        LimitSpeed();
	}

    private void LimitSpeed()
    {
        if (head.velocity.magnitude > maxSpeed)
        {
            if (moveRight)
            {
                head.velocity = new Vector2(maxSpeed, maxSpeed);
            }
            if (moveLeft)
            {
                head.velocity = new Vector2(-maxSpeed, maxSpeed);
            }
        }
    }

    private void Move()
    {
        if (moveRight)
        {
            RotateRight();
            moveRight = false;
        }
        else if (moveLeft)
        {
            RotateLeft();
            moveLeft = false;
        }
    }

    private void RotateLeft()
    {
        head.transform.Rotate(Vector3.forward * rotateAngle);

        head.AddForce(new Vector2(-1, 1) * moveForce);
    }

    private void RotateRight()
    {
        head.transform.Rotate(Vector3.back * rotateAngle);

        head.AddForce(new Vector2(1, 1) * moveForce);
    }
}
