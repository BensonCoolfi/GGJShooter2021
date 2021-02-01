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
        // ResumeGame();
    }

    public void ShowManuPauseGame()
    {
        ManuPause.SetActive(true);
        MainCanvas.SetActive(false);
        QuitScreen.SetActive(false);
    }

    public void ShowQuitScreen()
    {
        ManuPause.SetActive(false);
        MainCanvas.SetActive(false);
        QuitScreen.SetActive(true);
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
