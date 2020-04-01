using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OvenCreate4 : MonoBehaviour
{
    public GameObject spawnee;
    public bool stopSpawing = false;
    public float spawnTime;
    public float spawnDelay;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);

    }

    // Update is called once per frame
    public void SpawnObject()
    {
        GameObject CurrentOven = GameObject.Find("GlobalEffects");
        OvenSelector ovenSelect = CurrentOven.GetComponent<OvenSelector>();


        if (ovenSelect.oven == 4)
        {
            print("is 4");
            Instantiate(spawnee, transform.position, transform.rotation);
            if (stopSpawing)
            {
                CancelInvoke("SpawnObject");

            }
        }
        if (ovenSelect.oven != 4)
        {
          

        }
    }
}
