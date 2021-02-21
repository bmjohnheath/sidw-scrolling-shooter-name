using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolemMovement : MonoBehaviour {


    public float speed;

    private float jumpforce = 2.0f;

    public Vector2 jump;

    Rigidbody2D rb2d;

    public bool isGrounded;

    public Vector2 jumpheight;

    // Use this for initialization
    void Start ()
    {
        rb2d = GetComponent<Rigidbody2D>();
        jump = new Vector2(0.0f, 1.5f);
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) 
        {
            rb2d.AddForce(jump * jumpforce, ForceMode2D.Impulse);
            isGrounded = false;
            
        }
        
    }
    // Checks if player is on the ground
    private void OnCollisionEnter2D()
    {
        isGrounded = true;
        
    }

    // Movement script
    void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");

        
        rb2d.velocity = new Vector2(speed * move, rb2d.velocity.y);
    }
}
