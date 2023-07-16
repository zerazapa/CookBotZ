using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class BController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    string nivel1 = "Scene1";
    string menu = "Scene2";
    private RectTransform buttonRectTransform;
    private Vector2 originalPosition;
    public float newX = 10f;
    public float newY = 10f;
    public Vector2 targetPosition;
    public float moveSpeed = 5f;
    static bool canBePaused;
    public static bool isPaused;
    private int defaultLayer;

    private void Start()
    {
        buttonRectTransform = GetComponent<RectTransform>();
        originalPosition = buttonRectTransform.anchoredPosition;
        targetPosition = originalPosition;
        defaultLayer = LayerMask.NameToLayer("Default");
    }

    public void Pausedd()
    {
        isPaused = true;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        canBePaused = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        canBePaused = false;
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

        if (isPaused && Input.GetMouseButtonDown(0) && !IsPointerOverUIObject())
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
    }

    public void Restart()
    {
        if (isPaused)
        {
            SceneManager.LoadScene(nivel1);
            for(int a = 0; a<10; a++)
            {
                isPaused = false;
            }
            
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
