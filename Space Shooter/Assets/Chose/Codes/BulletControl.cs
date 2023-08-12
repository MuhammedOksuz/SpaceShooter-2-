using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{

    Rigidbody bulletRB;
    public float speed;
    void Start()
    {
        bulletRB = GetComponent<Rigidbody>();
        bulletRB.velocity = transform.forward * speed;
    }

    
    void Update()
    {
        
    }
}
