using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnHead : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Transform Head;
    [SerializeField] private Transform respawnPoint;

    void OnTriggerEnter(Collider Player)
    {
        Debug.Log("OnCollisionEnter works.");
        if (Player.gameObject.name == "Player")
        {
            Debug.Log("The GameObject name is Player.");
            Head.transform.position = respawnPoint.transform.position;

        }
    }

}
