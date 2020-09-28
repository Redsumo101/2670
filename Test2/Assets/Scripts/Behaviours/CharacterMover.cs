using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class CharacterMover : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 movement;
    public float gravity = 9.81f;
    public float moveSpeed = 3f;
    private float jumpForce = 100f;
    public int jumpCountMax;
    private int jumpCount;
    public float jumpForceMax = 100f;
    void Start()
    {
        controller = GetComponent<CharacterController>();
       
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal") * moveSpeed;
        movement.z = Input.GetAxis("Vertical") * moveSpeed;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = 6;
        }
        else
        {
            moveSpeed = 3;
        }
       
        
        if (Input.GetButtonDown("Jump"))
        {
            movement.y = jumpForce;
            jumpCount -= 1;
            if (jumpCount == 0)
            {
                jumpForce = 0 ;
            }
           
            
        }

        if (controller.isGrounded)
        {
            jumpCount = jumpCountMax;
            movement.y = 0;
            jumpForce = jumpForceMax;
        }
        else
        {
            movement.y -= gravity;
        }
        
       
       
        controller.Move(movement* Time.deltaTime);
    }
}
