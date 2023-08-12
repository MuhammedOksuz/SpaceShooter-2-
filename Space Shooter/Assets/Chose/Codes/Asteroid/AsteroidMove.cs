using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMove : MonoBehaviour
{

    Rigidbody asteroidRB;
    public float asteroidSpeed;
    void Start()
    {
        asteroidRB = GetComponent<Rigidbody>();
        asteroidRB.velocity = transform.forward * asteroidSpeed;
    }

    
   
}
