using System;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    private Rigidbody rb;
    private InputScript input;

    private float moveSpeed = 5f;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        input = GetComponent<InputScript>();
    }

    void Start()
    {
        
    }

  
    void Update()
    {
        


    }

    private void FixedUpdate()
    {
        Vector3 direction = new Vector3(input.Move.x, 0 , input.Move.y);
        Vector3 move = transform.TransformDirection(direction) * moveSpeed;
        rb.linearVelocity = new Vector3(move.x, rb.linearVelocity.y, move.z);
    }
}
