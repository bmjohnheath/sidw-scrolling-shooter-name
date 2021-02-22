using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunshoting : MonoBehaviour
{

    public GameObject shootpoint;
    public GameObject bullet;
    public float cooldown;
    public float timerreduction;
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

        cooldown -= timerreduction * Time.deltaTime;

        if (Input.GetKey(KeyCode.N)&& cooldown <=0)
        {
            Instantiate(bullet.gameObject, shootpoint.transform.position, shootpoint.transform.rotation);
            cooldown = 1;
        }
    }
}
