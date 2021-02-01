using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
       // PauseGame();
    }

    public void CloseQuitScreen()
    {
        QuitScreen.SetActive(false);
        MainCanvas.SetActive(true);
       // ResumeGame();
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
