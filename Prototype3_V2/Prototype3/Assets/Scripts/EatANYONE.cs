﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatANYONE : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject && col.gameObject.name != "Terrain" && col.gameObject.name != "Oven1" && col.gameObject.name != "Oven2" && col.gameObject.name != "Oven3" && col.gameObject.name != "Oven4" && col.gameObject.name != "Oven5" && col.gameObject.name != "Oven6")
        {
            Debug.Log("Collision Decected");
            Destroy(col.gameObject);
        }
    }

}