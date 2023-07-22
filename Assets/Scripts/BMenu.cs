using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class BMenu : MonoBehaviour
{
    string nivel1 = "nv1";
    string prac = "practice";
    string tuto = "tuto";

    public static bool pressed = false;
    public static bool statsPressed = false;
    public static bool settingsPressed = false;
    public static bool inputsPressed = false;
    public static bool creditsPressed = false;

    void Start()
    {
        Time.timeScale = 1f;
    }


    void Update()
    {
        if (pressed && Input.GetMouseButtonDown(0) && !IsPointerOverUIObject())
        {
            pressed = false;
        }
    }

    public void Play()
    {
        SceneManager.LoadScene(nivel1);
    }
    public void Practice()
    {
        SceneManager.LoadScene(prac);
    }
    public void Tutorial()
    {
        SceneManager.LoadScene(tuto);
    }
    public void Stats()
    {
        statsPressed = true;
    }
    public void Settings()
    {
        LeanTween.scale(gameObject, new Vector3 (0,0,0), 0.5f);
    }
    public void Credits()
    {
        creditsPressed = true;
    }
    public void Exit()
    {
        Application.Quit();
    }

    private bool IsPointerOverUIObject()
    {
        return EventSystem.current.IsPointerOverGameObject();
    }
}
