using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtBehaviour : MonoBehaviour
{
    public Transform player;
    private float PlayerAngle;
    public float turnSpeed;

  private void Update()
  {
      Rotate();
  }

  void Rotate()
  {
      PlayerAngle += Input.GetAxis("Mouse X") * turnSpeed * -Time.deltaTime;
      player.localRotation = Quaternion.AngleAxis(PlayerAngle, Vector3.up);
  }
}
