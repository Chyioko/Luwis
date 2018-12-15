using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu_gamepad : MonoBehaviour
{

    public static bool HraJePozastavena = false;
    public GameObject pauseMenuUI;
    void Update()
    {
        if (Input.GetButtonDown("B_Button"))
        {
            if (HraJePozastavena)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        HraJePozastavena = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        HraJePozastavena = true;
    }
    public void LoadMenu()
    {
       
    }
    public void QuitMenu()
    {

    }
}