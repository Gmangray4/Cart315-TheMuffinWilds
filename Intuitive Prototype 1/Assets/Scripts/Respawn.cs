using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    [SerializeField] private Transform Player;
    [SerializeField] private Transform respawnPoint;

    void OnTriggerEnter(Collider Player)
    {
        if (Player.gameObject)
        {
            Player.transform.position = respawnPoint.transform.position;
        }
    }



}
