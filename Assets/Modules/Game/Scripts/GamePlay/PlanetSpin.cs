﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSpin : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, -8 * Time.deltaTime, 0, Space.Self);
    }
}
