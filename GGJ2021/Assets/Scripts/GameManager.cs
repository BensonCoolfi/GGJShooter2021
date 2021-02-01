using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public CameraController CameraController;
    public GameObject Player1, Player2;

    public GameObject demonContainer, hudContainer, gameOverPanel;
    public TextMeshProUGUI demonCounter, timeCounter;
    public bool gamePlaying { get; private set; }

    private int numTotalDemons, numSlayedDemons;
    private float startTime, elapsedTime;

    private void Awake()
    {
        instance = this;         
    }

    private void Start()
    {
        numTotalDemons = demonContainer.transform.childCount;
        numSlayedDemons = 0;
        demonCounter.text = "Demons: 0 / " + numTotalDemons;

        gamePlaying = true;
    }

    public void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            CameraController.switchCamera();
            Player1.SetActive(false);
            Player2.SetActive(true);
        }
    }

    public void SlayDemon()
    {
        numSlayedDemons++;
        string demonCounterStr = "Demons: " + numSlayedDemons + " / " + numTotalDemons;
        demonCounter.text = demonCounterStr;

       if (numSlayedDemons >= numTotalDemons)
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        gamePlaying = false;
        Invoke("ShowGameOverScreen", 0.5f);
    }

    public void ShowGameOverScreen()
    {
        gameOverPanel.SetActive(true);
        hudContainer.SetActive(false);
    }
 
    public void HideGameOverScreen()
    {
        gameOverPanel.SetActive(false);
        hudContainer.SetActive(true);
    }
}
