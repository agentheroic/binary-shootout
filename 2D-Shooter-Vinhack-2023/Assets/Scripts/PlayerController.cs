using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D theRB;

    public float moveSpeed;

    public float jumpForce;

    public Transform groundPoint;
    private bool isOnGround;
    public LayerMask whatisGround;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, theRB.velocity.y);

        isOnGround = Physics2D.OverlapCircle(groundPoint.position, .2f, whatisGround);


        if(Input.GetButtonDown("Jump") && isOnGround)
        {
            theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);
        }

    }
}
