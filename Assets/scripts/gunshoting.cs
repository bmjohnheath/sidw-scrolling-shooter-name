using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunshoting : MonoBehaviour
{

    public GameObject shootpoint;
    public GameObject bullet;
    
    // Start is called before the first frame update
    void Start()
    {
        bullet = Resources.Load("Prefab/bullet") as GameObject;
        shootpoint = GameObject.Find("shootpointPlayer");
    }
    public void Atk()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {

        }
    }
}
