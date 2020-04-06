using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillPlayer : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Transform respawnPoint;
 

    void OnTriggerEnter(Collider Player)
    {
        Debug.Log("OnCollisionEnter works.");
        if (Player.gameObject.name == "Player")
        {
            Debug.Log("The GameObject name is Player.");
      
            
            Player.transform.position = respawnPoint.transform.position;
         
        }
    }

}
