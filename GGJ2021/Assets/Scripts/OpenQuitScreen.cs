using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OpenQuitScreen : MonoBehaviour
{
    public GameObject QuitScreen;
    public GameObject MainCanvas;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            if (QuitScreen.activeSelf)
            { CloseQuitScreen(); }

            else ShowQuitScreen();
        }
    }

    public void ShowQuitScreen()
    {
        QuitScreen.SetActive(true);
        MainCanvas.SetActive(false);

    }

    public void CloseQuitScreen()
    {
        QuitScreen.SetActive(false);
        MainCanvas.SetActive(true);
    }

    public void ShowManuPauseGame()
    {
        QuitScreen.SetActive(false);
        MainCanvas.SetActive(true);
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit ();
#endif
    }
}
