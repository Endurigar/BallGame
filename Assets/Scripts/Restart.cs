using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Containers;

public class Restart : MonoBehaviour
{
    [SerializeField] private Button restartButton;
    [SerializeField] private GameObject sphere;
    [SerializeField] private GameObject platform;
    private Vector3 sphereSpawnPosition;
    private Quaternion platformSpawnPosition;

    private void Start()
    {
        restartButton.onClick.AddListener(RestartPosition);
        sphereSpawnPosition = sphere.transform.position;
        platformSpawnPosition = sphere.transform.rotation;
    }

    private void Update()
    {
        Lose();
    }
    private void Lose()
    {
        if (sphere.gameObject.transform.position.y < -1)
        {
            restartButton.gameObject.SetActive(true);
            ActionContainer.OnLose();
        }
    }
    private void RestartPosition()
    {
        sphere.transform.position = sphereSpawnPosition;
        platform.transform.rotation = platformSpawnPosition;
        restartButton.gameObject.SetActive(false);
        ActionContainer.OnTimerActive();
    }
}
