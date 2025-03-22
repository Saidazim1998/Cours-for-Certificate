using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class RaceTimer : MonoBehaviour
{
    public bool isRaceStarted = false;

    public TextMeshProUGUI raceTimerText;
    public GameObject mainMenu;
    public static float time = 0;
    public TimeSpan playingTime;

    private void OnEnable()
    {
        GameEvents.OnStartRaceEvent += StartTimer;
        GameEvents.OnStopRaceEvent += StopTimer;
    }

    private void OnDisable()
    {
        GameEvents.OnStartRaceEvent -= StartTimer;
        GameEvents.OnStopRaceEvent -= StopTimer;
    }

    private void StartTimer()
    {
        time = 0;
        // Start timer
        StartCoroutine(nameof(Timer));
        isRaceStarted = true;
    }

    private void StopTimer()
    {
        if (isRaceStarted)
        {
            // Stop timer
            StopCoroutine(nameof(Timer));
            // print result
            raceTimerText.text = playingTime.ToString("mm':'ss':'ff");
            mainMenu.SetActive(true);
            print("Race Timer:"+playingTime.ToString("mm':'ss':'ff"));
        }
    }

    IEnumerator Timer()
    {
        while (true)
        {
            time += Time.deltaTime;
            playingTime = TimeSpan.FromSeconds(time);
            yield return null;
        }
      
    }
}
