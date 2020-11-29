using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class CharacterMover : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 movement;
    public float gravity = 9.81f;
    public float moveSpeed = 3f;
    private float jumpForce = 100f;
    public float jumpCountMax;
    public float jumpCount;
    public float jumpForceMax = 100f;
    private StatsBehavior stats;
    
    void Start()
    {
        
        controller = GetComponent<CharacterController>();
        stats = GetComponent<StatsBehavior>();
        jumpCount = stats.jump;
        moveSpeed = stats.moveSpeed;
        


    }

    // Update is called once per frame
    void Update()
    {
        
        
        movement.x = Input.GetAxis("Horizontal") * moveSpeed;
        movement.z = Input.GetAxis("Vertical") * moveSpeed;
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = stats.sprint;
        }
        else
        {
            moveSpeed = stats.moveSpeed;
        }
       
        
        if (Input.GetButtonDown("Jump"))
        {
            jumpCount -= 1;
            movement.y = jumpForce;
            
        }
        
        if (jumpCount <= 0)
        {
            jumpForce = 0 ;
        }
        if (controller.isGrounded)
        {
            stats = GetComponent<StatsBehavior>();
            jumpCount = stats.jump;
            jumpForce = jumpForceMax;
        }
        else
        {
            movement.y -= gravity ;
        }
        
       
       
        controller.Move(movement* Time.deltaTime);
    }

    private Vector3 direction = Vector3.zero;
    public float pushPower = 3f;
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        var body = hit.collider.attachedRigidbody;
        if (body == null)
        {
            return;
        }
        direction.Set(hit.moveDirection.x,0, hit.moveDirection.z);
        var pushDirection = direction * pushPower;
        body.velocity = pushDirection;
    }
}
