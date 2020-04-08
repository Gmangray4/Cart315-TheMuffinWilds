using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OvenInnerLight4 : MonoBehaviour
{
    float lightStep = 1;
    float lightVal = 0;
    float currentlight = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        GameObject CurrentOven = GameObject.Find("GlobalEffects");
        OvenSelector ovenSelect = CurrentOven.GetComponent<OvenSelector>();

        if (lightVal < 0)
        {
            lightVal = 1;
        }

        if (lightVal >= 0 && lightVal <= 10 && ovenSelect.oven == 4)
        {
            lightVal += lightStep * Time.deltaTime;

        }
        if (lightVal >= 0 && ovenSelect.oven != 4)
        {
            lightVal -= lightStep * Time.deltaTime;
        }

        currentlight = lightVal;
        this.GetComponent<Light>().intensity = currentlight;
    }
}
