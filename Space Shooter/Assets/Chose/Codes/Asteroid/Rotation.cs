using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    Rigidbody rotationRB;
    public float speed;
    
    void Start()
    {
        rotationRB = GetComponent<Rigidbody>();
        rotationRB.angularVelocity = Random.insideUnitSphere*speed;          // angularVelocity = A��sal H�z� Yani Rotasyonu hareket ettirir. // insideUnitSphere = Rotation'u k�resel �evir. 
        
    }

    
}
