using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{

    Rigidbody2D rb;
    [SerializeField]
    private float speed = 7;

    [SerializeField]
    private float jumpForce = 7;
    [SerializeField]
    public Transform groundChecker ;

    [SerializeField]
   private LayerMask  floorLayerMask;

    private bool isGrounded = false;
    private bool jumpedInAir = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
      //transform.Translate (Vector2.right * 0.01f);
    }

    private void CheckIsGrounded()
    {
        var hit =Physics2D.Raycast(groundChecker.position, Vector2.down, 0.1f,floorLayerMask);
        if (hit.collider != null)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded =false;
        }
    }

    internal void Addpoint()
    {
        throw new NotImplementedException();
        
    }

    void Update()
    {
        CheckIsGrounded();
        float xMove = 0;
        float yMove = rb.velocity.y;
        if (Input.GetKey(KeyCode.D))
        {
            //rb . AddForce (Vector2.right * speed);
            xMove = speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            //rb . AddForce (Vector2.right * speed);
            xMove = -speed;
        }

        if (Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
               yMove = jumpForce;
            }
            else
            {
                if (jumpedInAir)
                {
                    yMove = jumpForce;
                    jumpedInAir = true;
                }
            }
           
        }
        rb.velocity = new Vector2(xMove, rb.velocity.y);
    }
}
