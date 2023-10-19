using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject controlsTutorial;

    public void Play()
    {
        SceneManager.LoadScene("Hangar");
    }

    public void ControlsTutorial()
    {
        mainMenu.SetActive(false);
        controlsTutorial.SetActive(true);
    }

    public void BackToMenu()
    {
        controlsTutorial.SetActive(false);
        mainMenu.SetActive(true);
    }
}
