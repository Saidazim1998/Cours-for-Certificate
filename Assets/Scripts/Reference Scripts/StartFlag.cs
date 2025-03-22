using System;
using UnityEngine;

public class StartFlag : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            print("RACE STARTED!");
            GameEvents.StartRace();
        }
    }
}
