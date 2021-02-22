using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladder : MonoBehaviour
{

    // public GameObject player;
    public bool inladderarea;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Debug.Log("player in ladder");
            inladderarea = true;

        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            inladderarea = false;
            player.GetComponent<Playermovement>().laddermovent = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(inladderarea == true)
        {
            player.GetComponent<Playermovement>().laddermovent = true;
        }
    }
}
