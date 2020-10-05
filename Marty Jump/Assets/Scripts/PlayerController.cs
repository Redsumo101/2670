using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 20f;
    public float rotationSpeed = 10f;

    private Rigidbody rbody;

    private float horizontal;

    private float vertical;
    
    private Vector3 movement;
    
    public float DodgeCoolDown = 1;
    private float ActCoolDown;
   
    
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bool Dodge = (Input.GetKey(KeyCode.LeftAlt));
        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = 50;
        }
        else
        {
            moveSpeed = 20;
            
        }
       
        
        if (ActCoolDown <= 0)
        {
            if (Dodge)
            {
                Roll();
            }
        }
        else
        {
            moveSpeed = 20;
            ActCoolDown -= Time.deltaTime;
        }
        
        
        
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        movement = new Vector3(horizontal,0,vertical) * (moveSpeed * Time.deltaTime);
        rbody.MovePosition(transform.position + movement);
        
    }

    void Roll()
    {
        ActCoolDown = DodgeCoolDown;
        moveSpeed = 300;
    }
}
