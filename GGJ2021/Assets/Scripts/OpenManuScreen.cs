using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OpenManuScreen : MonoBehaviour
{
    public GameObject MainCanvas;
    public GameObject ManuPause;
    public GameObject QuitScreen;
    public PlayerMovement playerMovement1, playerMovement2;
    public Shooting playerShooting1, playerShooting2;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            if (ManuPause.activeSelf)
            { CloseManuScreen(); }

            else ShowManuPauseGame();
        }
    }

    public void CloseManuScreen()
    {
        ManuPause.SetActive(false);
        MainCanvas.SetActive(true);
        QuitScreen.SetActive(false);
        playerMovement1.enabled = true;
        playerMovement2.enabled = true;
        playerShooting1.enabled = true;
        playerShooting2.enabled = true;
        // ResumeGame();
    }

    public void ShowManuPauseGame()
    {
        ManuPause.SetActive(true);
        MainCanvas.SetActive(false);
        QuitScreen.SetActive(false);
        playerMovement1.enabled = false;
        playerMovement2.enabled = false;
        playerShooting1.enabled = false;
        playerShooting2.enabled = false;
    }

    public void ShowQuitScreen()
    {
        ManuPause.SetActive(false);
        MainCanvas.SetActive(false);
        QuitScreen.SetActive(true);
        playerMovement1.enabled = false;
        playerMovement2.enabled = false;
        playerShooting1.enabled = false;
        playerShooting2.enabled = false;
    }

   /*** public void PauseGame()
    {
        Time.timeScale = 0;
        PlayerAnim.enabled = false;
        AttackButton.enabled = false;
        HealButton.enabled = false;
    }
   
    public void ResumeGame()
    {
        Time.timeScale = 1;
        PlayerAnim.enabled = true;
        AttackButton.enabled = true;
        HealButton.enabled = true;
    }
**/
    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit ();
#endif
    }
}
