using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Cinemachine;
using UnityEngine;
public class Obstacle : MonoBehaviour
{
    private CinemachineImpulseSource _impulseSource;

    private void Start()
    {
        _impulseSource = GetComponent<CinemachineImpulseSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            HitPlayer(collision.gameObject);
            Shake();
        }
    }

    public virtual void HitPlayer(GameObject player)
    {
        //print("I hit the player");
        PlayerEvents.PlayerHit();
    }

    public void Shake()
    {
        _impulseSource.GenerateImpulse();
    }
    
}
