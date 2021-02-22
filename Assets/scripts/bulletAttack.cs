using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletAttack : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D onbullet;
    public float speed;
  
    void Start()
    {
        onbullet = GetComponent<Rigidbody2D>();
        Destroy(gameObject,5);
       // cooldown = 1;
       // onbullet.AddForce(transform.right * speed);
        // InvokeRepeating("destroyitself", 10f);
    }

    // Update is called once per frame
    void Update()
    {
        onbullet.AddForce(transform.right * speed);
      // onbullet.velocity = transform.right * speed;

    }
     public void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.tag == "Player")
        {

        }
        else
        {
            Destroy(gameObject);
        }
        
       
    }
}
