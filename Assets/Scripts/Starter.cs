using Containers;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Starter : MonoBehaviour
{
    [SerializeField] private Button startButton;
    private bool gameStarted = false;

    private void Start()
    {
        startButton.onClick.AddListener(GameStarted);
    }
    private void Update()
    {
        ResumeGame();
    }
    private void ResumeGame()
    {
        if(gameStarted == true)
        {
            Time.timeScale = 1;
        }
        if(gameStarted == false)
        {
            Time.timeScale = 0;
        }
    }
    private void GameStarted()
    {
        ActionContainer.OnTimerActive();
        startButton.gameObject.SetActive(false);
        gameStarted = true;
    }
}
