﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrilControle : MonoBehaviour
{
    private GameControle     _GameControle;
    private Rigidbody2D      barrilRb;
    void Start()
    {
        _GameControle = FindObjectOfType(typeof(GameControle)) as GameControle;
        barrilRb = GetComponent<Rigidbody2D>();

        barrilRb.velocity = new Vector2(_GameControle.velocidadeObjeto,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= _GameControle.distanciaDestruir)
        {
            Destroy(this.gameObject);
        }
    }
}
