﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nota : MonoBehaviour
{
    Rigidbody2D rb;
    public float velocitat;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        rb.velocity = new Vector2(0, -velocitat);
    }

    void Update()
    {
        
    }
}
