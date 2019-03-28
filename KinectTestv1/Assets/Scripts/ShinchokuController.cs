﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShinchokuController : MonoBehaviour {

    public float lifeTime = 10.0f;
    private float delta = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta >= lifeTime)
        {
            Destroy(gameObject);
        }
    }

}
