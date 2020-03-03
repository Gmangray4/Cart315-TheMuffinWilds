using System.Collections;
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
        if (col.gameObject && col.gameObject.name != "Terrain")
        {
            Debug.Log("Collision Decected");
            Destroy(col.gameObject);
        }
    }

}
