using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public delegate void OnStartRace();
    public static event OnStartRace OnStartRaceEvent;
    public delegate void OnStopRace();
    public static event OnStopRace OnStopRaceEvent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public static void StartRace()
    {
        if (OnStartRaceEvent!=null)
        {
            OnStartRaceEvent();
        }
    }

    public static void StopRace()
    {
        if (OnStopRaceEvent != null)
        {
            OnStopRaceEvent();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
