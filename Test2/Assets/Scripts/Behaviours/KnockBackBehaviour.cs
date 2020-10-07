using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class KnockBackBehaviour : MonoBehaviour
{
    private CharacterController controller;

    Vector3 move = Vector3.left;
    void Update()
    {
        controller = GetComponent<CharacterController>();
        controller.Move(move*Time.deltaTime);
    }
    private IEnumerator KnockBack(ControllerColliderHit hit)
    {
        var i = 2f;
        move = hit.collider.attachedRigidbody.velocity*i;
        while (i > 0)
        {
            yield return new WaitForFixedUpdate();
            i -= 0.1f;
        }
        move = Vector3.left;
    }

    public float pushPower = 10f;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        var body = hit.collider.attachedRigidbody;
        if (body == null || body.isKinematic)
        {
            return;
        }

        if (hit.moveDirection.y < -0.3)
        {
            return;
        }
       
    }

   
}
