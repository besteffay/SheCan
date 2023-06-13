using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D playerRigidbody;
    private Animator anim;
    private SpriteRenderer sprite;
    private BoxCollider2D coll;

    [SerializeField] private LayerMask jumpableGround;

    [SerializeField] private float jumpForce = 13f;
    [SerializeField] private float walkSpeed = 5f;
    private float dirX = 0f;

    private enum MovementState {idle, walking, jumping, falling};

    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        coll = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        if(Input.GetKeyDown("space") && IsGrounded())                                                                   // jump
        {
            playerRigidbody.velocity = new Vector2(playerRigidbody.velocity.x, jumpForce);
        }

        dirX = Input.GetAxis("Horizontal");                                                             // walk
        playerRigidbody.velocity = new Vector2(dirX * walkSpeed, playerRigidbody.velocity.y);

        UpdateAnimationState();                                                                         // switching between animations
    } 

    private void UpdateAnimationState()
    {
        MovementState state;

        if(dirX > 0f)
        {
            state = MovementState.walking;
            sprite.flipX = false;
        }
        else if (dirX < 0f)
        {
            state = MovementState.walking;
            sprite.flipX = true;
        }
        else
        {
            state = MovementState.idle;
        }

        if(playerRigidbody.velocity.y > 0.1f)
        {
            state = MovementState.jumping;
        }
        else if(playerRigidbody.velocity.y < -0.1f)
        {
            state = MovementState.falling;
        }

        anim.SetInteger("state", (int)state);
    }

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, 0.1f, jumpableGround);
    }
}
