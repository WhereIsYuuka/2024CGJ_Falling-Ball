﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlane : MonoBehaviour
{
    public int force;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player") {
            other.gameObject.GetComponent<PlayerMovement>().Jump(force);
        }
    }
}
