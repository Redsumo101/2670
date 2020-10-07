using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{ public float jumpSpeed = 8.0F;
  public float gravity = 20.0F;
  private Vector3 moveDirection;
  public CharacterController controller;

  void Start()
  {
      
  }
  void Update() {
      if (controller.isGrounded && Input.GetButton("Jump")) {
          moveDirection.y = jumpSpeed;
      }
      moveDirection.y -= gravity * Time.deltaTime;
      controller.Move(moveDirection * Time.deltaTime);
  }
}
