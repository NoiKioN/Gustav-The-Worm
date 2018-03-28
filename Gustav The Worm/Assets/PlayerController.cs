using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveForce;

    Rigidbody2D head;
    Rigidbody2D[] bodyPartsRigidbodies;

	void Start ()
    {
        head = GetComponent<Rigidbody2D>();
        bodyPartsRigidbodies = GetComponentsInChildren<Rigidbody2D>();
	}
	
	void FixedUpdate ()
    {
        Move();
	}

    private void Move()
    {
        
    }
}
