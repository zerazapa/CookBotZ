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
    public float finishX = 10f;
    public float finishY = 10f;
    public Vector2 targetPosition;
    public float moveSpeed = 3f;
    public static bool isPaused;
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

        if ((isPaused && !Timer.isGameOver) || (isPaused && Timer.isGameOver))
        {
            if (gameObject.name != "display help")
            {
                targetPosition = new Vector2(newX, newY);
            }
        }
        else if (!isPaused && !Timer.isGameOver)
        {
            if (gameObject.name != "display help")
            {
                targetPosition = originalPosition;
            }
        }
        else if (!isPaused && Timer.isGameOver)
        {
            targetPosition = new Vector2(finishX, finishY);
        }

        if ((isPaused && Input.GetMouseButtonDown(0) && !IsPointerOverUIObject() && !Timer.isGameOver))
        {
            isPaused = false;
        }

        if (Input.GetKey(KeyCode.Escape) && isPaused)
        {
            isPaused = false;
        }

        if (isPaused)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }

    public void Restart()
    {
        if (isPaused)
        {
            SceneManager.LoadScene(estaescena);
        }
        Timer.isGameOver = false;
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
