using System;
using UnityEngine;

public class StopFlag : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameEvents.StopRace();
        }
    }
}
