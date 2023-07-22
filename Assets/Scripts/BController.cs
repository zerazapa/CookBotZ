using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class BController : MonoBehaviour
{
    string estaescena = "";
    string menu = "menu";
    private RectTransform buttonRectTransform;
    private Vector2 originalPosition;
    public float newX = 10f;
    public float newY = 10f;
    public Vector2 targetPosition;
    public float moveSpeed = 5f;
    public static bool isPaused;
    public static bool isGameOver = false;
    private int defaultLayer;

    private void Start()
    {
        estaescena = SceneManager.GetActiveScene().name;
        buttonRectTransform = GetComponent<RectTransform>();
        originalPosition = buttonRectTransform.anchoredPosition;
        targetPosition = originalPosition;
        defaultLayer = LayerMask.NameToLayer("Default");
        isPaused = false;
    }

    public void Pausedd()
    {
        isPaused = true;
    }


    private void Update()
    {
        buttonRectTransform.anchoredPosition = Vector2.Lerp(buttonRectTransform.anchoredPosition, targetPosition, moveSpeed * Time.unscaledDeltaTime);

        if (isPaused)
        {
            targetPosition = new Vector2(newX, newY);
        }
        else
        {
            targetPosition = originalPosition;
        }

        if (isPaused && Input.GetMouseButtonDown(0) && !IsPointerOverUIObject() && !isGameOver)
        {
            isPaused = false;
            Time.timeScale = 1f;
        }

        if (isPaused)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }

        if (isGameOver)
        {
            Debug.Log("perdiste wachite");
        }
    }

    public void Restart()
    {
        if (isPaused)
        {
            SceneManager.LoadScene(estaescena);
        }
    }

    public void BackToMenu()
    {
        if (isPaused)
        {
            SceneManager.LoadScene(menu);
        }
    }

    public void QuitGame()
    {
        if (isPaused)
        {
            Application.Quit();
        }
    }

    private bool IsPointerOverUIObject()
    {
        return EventSystem.current.IsPointerOverGameObject();
    }
}
