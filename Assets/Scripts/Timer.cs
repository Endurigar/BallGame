using UnityEngine;
using TMPro;
using System;
using Containers;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    private float currentTime;
    private bool gameIsActive = false;

    private void Start()
    {
        ActionContainer.OnLose += StopCounting;
        ActionContainer.OnTimerActive += StartCounting;
    }
    private void Update()
    {
        TimeCounter();
    }
    private void TimeCounter()
    {
        if(gameIsActive == true)
        {
            currentTime += Time.deltaTime;
            timerText.text = Math.Round(currentTime, 1).ToString();
        }
    }
    private void StopCounting()
    {
        currentTime = 0f;
        gameIsActive = false;
    }
    private void StartCounting()
    {
        gameIsActive = true;
    }
}
