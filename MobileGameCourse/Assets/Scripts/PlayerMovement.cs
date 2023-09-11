using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Variables
    public int jumpHeight;
    public int speed;
    public Rigidbody2D playerRb;
    public bool grounded;
    public States stateManager;
    public AudioManager jumpSound;

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            if (grounded && stateManager.state == "Alive")
            {
                Jump();
                jumpSound.PlayJump();
            }
        }

    }

    void FixedUpdate()
    {

        if (stateManager.state == "Alive")
        {
            playerRb.velocity = new Vector2(speed, playerRb.velocity.y);
        }
        else
        {
            playerRb.velocity = Vector2.zero;
        }

    }

    public void ResetGravity(int x)
    {
        playerRb.gravityScale = x;
    }

    void Jump()
    {
        playerRb.velocity = new Vector2(playerRb.velocity.x, jumpHeight);
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Ground"))//I think this is probably the code to fix so a last minute jump using the camera border as a collider doesn't work
            grounded = true;
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Ground"))
            grounded = false;
    }

}
