using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Transform respawnPoint;

    void OnTriggerEnter(Collider Player)
    {
        Debug.Log("OnCollisionEnter works.");
        if (Player.gameObject.name == "FPSController")
        {
            Debug.Log("The GameObject name is Cube.");
            Player.transform.position = respawnPoint.transform.position;
         
        }
    }

}
