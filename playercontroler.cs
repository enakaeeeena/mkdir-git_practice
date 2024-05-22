using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEditor.Tilemaps;
using UnityEngine;

public class playercontroler : MonoBehaviour
{

    private Rigidbody2D rigidbody2d;
    private Vector2 movement;
    public float moveSpeed;

    private Animator animator;
    private bool looksLeft = false;

    void Start()
    {
        rigidbody2d = this.GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");


    }

    private void FixedUpdate()
    {
        rigidbody2d.MovePosition(rigidbody2d.position + movement * moveSpeed * Time.fixedDeltaTime);

        if ((movement.x < 0) && looksLeft)
        {   Flip();
    } else if((movement.x>0)&& looksLeft)
   { 
         Flip();
   }
   }

   private void Flip()
  { 
    looksLeft = !looksLeft;
    transform.Rotate(0f, 180f, 0f);
   }

}
