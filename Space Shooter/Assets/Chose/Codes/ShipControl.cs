using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControl : MonoBehaviour
{

    Rigidbody shipRB;
    float horizontal;
    float vertical;
    Vector3 shipVec;
    public float shipSpeed;
    public float inclination;  //eðim


    public GameObject fire;
    public Transform fireOut;
    public float fireSpeed;
    float fireCounter;
    AudioSource audio;


    public float minx;
    public float maxx;
    public float minz;
    public float maxz;

    void Start()
    {
        shipRB = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(Input.GetButton("Fire1") && Time.time>fireCounter)
        {
            fireCounter = Time.time + fireSpeed;
            Instantiate(fire, fireOut.position, Quaternion.identity);
            audio.Play();
        }
    }

    void FixedUpdate()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        shipVec = new Vector3(horizontal, 0, vertical);
        shipRB.velocity = shipVec*shipSpeed;


        shipRB.position = new Vector3(Mathf.Clamp(shipRB.position.x, minx, maxx), 0, Mathf.Clamp(shipRB.position.z, minz, maxz)) { };

        shipRB.rotation = Quaternion.Euler(0, 0,shipRB.velocity.x*-inclination);
    }
}
