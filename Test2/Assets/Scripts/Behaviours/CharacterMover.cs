using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(CharacterController))]
public class CharacterMover : MonoBehaviour
{
    public CharacterController controller;
    public StatsBehavior stats;
    private Vector3 velocity;
    public float jumpHeight = 3f;
    public float gravity = -9.81f;
    public Transform groundCheck;
    public float groundDistance;
    public LayerMask groundMask;
    private bool isGrounded;
    public float jumpCount;
    public float moveSpeed;
    

    public void Start()
    {
        stats = GetComponent<StatsBehavior>();
        
    }
 

    // Update is called once per frame
    public void Update()
    {
        
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
            jumpCount = stats.jump;
        }

        float x = Input.GetAxis("Horizontal") * moveSpeed;
        float z = Input.GetAxis("Vertical") * moveSpeed;

        Vector3 move = new Vector3(x, 0f, z).normalized;

        controller.Move(move * moveSpeed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && jumpCount > 0 )
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            jumpCount--;
        }
        
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = stats.sprint;
        }

        else
        {
            moveSpeed = stats.moveSpeed;
        }
    }

}
