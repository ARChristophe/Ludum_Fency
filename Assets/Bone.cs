﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bone : MonoBehaviour
{
    [Range (1f, 100f)]
    public float boneSpeed;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector3.up * boneSpeed, ForceMode2D.Impulse);
    }

    void OnTriggerEnter2D(Collider2D obectHit)
    {
        Destroy(this);  
    }


}
