using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncySquare : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        var vel = GetComponent<Velocity>();
        vel.vel *= -1;
    }
}
