using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public float speed;

      public  float jumpforce = 2.0f;

    public Vector2 jump;

    Rigidbody2D rb2d;

    public bool isGrounded;

    public Vector2 jumpheight;

    public LayerMask HitthisLayer;
    public Transform jumppoint;
    public bool laddermovent;
    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        jump = new Vector2(0.0f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        jumpcheck();
        
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb2d.AddForce(jump * jumpforce, ForceMode2D.Impulse);
            isGrounded = false;

        }
        if(Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.UpArrow) && laddermovent == true)
        {
            rb2d.AddForce(transform.up * speed);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow) && laddermovent == true)
        {
            rb2d.AddForce(-transform.up * (speed / 2));
        }


    }
    // Checks if player is on the ground
    //private void OnCollisionEnter2D()
    //{
    //    isGrounded = true;

    //}

    // Movement script
    public void jumpcheck()
    {
        // RaycastHit hit;
        RaycastHit2D hitInfo = Physics2D.Raycast(jumppoint.position, -jumppoint.up, 1); 
        // RaycastHit hit;
        //Vector3 shootdirection = jumppoint.transform.position + Vector3.up * 0.5f; ;
        //Debug.DrawRay(jumppoint.transform.position, shootdirection * 100, Color.red, 3.0f);
        if (hitInfo)
        {
          //  Debug.Log(hitInfo.collider.tag);
            
            if(hitInfo.collider.tag == "ground")
            {
               isGrounded = true;
            }

        }
       
        //else
        //{
        //   // isGrounded = false;
        //}
    }
    void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");
       // float climb = Input.GetAxis("");

        rb2d.velocity = new Vector2(speed * move, rb2d.velocity.y);
    }
}
