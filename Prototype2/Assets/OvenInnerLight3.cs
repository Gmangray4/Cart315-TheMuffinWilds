using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OvenInnerLight3 : MonoBehaviour
{
    float lightStep = 1;
    float lightVal = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        GameObject CurrentOven = GameObject.Find("GlobalEffects");
        OvenSelector ovenSelect = CurrentOven.GetComponent<OvenSelector>();

        if (lightVal >= 0 && lightVal <= 10 && ovenSelect.oven == 3)
        {
            lightVal += lightStep * Time.deltaTime;

        }
        if (lightVal >= 0 && ovenSelect.oven != 3)
        {
            lightVal -= lightStep * Time.deltaTime;
        }

        this.GetComponent<Light>().intensity = lightVal;
    }
}
