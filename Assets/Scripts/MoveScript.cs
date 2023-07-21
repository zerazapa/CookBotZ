using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MoveScript : MonoBehaviour
{
    private RectTransform buttonRectTransform;
    private Vector2 originalPosition;
    public Vector2 targetPosition;
    public float newX, newY, moveSpeed;
    public bool pressed;

    void Start()
    {
        buttonRectTransform = GetComponent<RectTransform>();
        originalPosition = buttonRectTransform.anchoredPosition;
        targetPosition = originalPosition;
    }

    // Update is called once per frame
    void Update()
    {
        buttonRectTransform.anchoredPosition = Vector2.Lerp(buttonRectTransform.anchoredPosition, targetPosition, moveSpeed * Time.unscaledDeltaTime);

        if (gameObject.name == "stats" && BMenu.statsPressed)
        {
            targetPosition = new Vector2(newX, newY);
        }
        if (gameObject.name != "stats" && BMenu.statsPressed)
        {
            buttonRectTransform.gameObject.SetActive(false);
        }
        if (gameObject.name == "stats" && !BMenu.statsPressed)
        {
            targetPosition = originalPosition;
        }
        if (gameObject.name != "stats" && !BMenu.statsPressed)
        {
            buttonRectTransform.gameObject.SetActive(true);
        }
        if (gameObject.name == "settings" && BMenu.settingsPressed)
        {
            targetPosition = new Vector2(newX, newY);
        }
        if (gameObject.name != "settings" && BMenu.settingsPressed)
        {
            buttonRectTransform.gameObject.SetActive(false);
        }
        if (gameObject.name == "settings" && !BMenu.settingsPressed)
        {
            targetPosition = originalPosition;
        }
        if (gameObject.name != "settings" && !BMenu.settingsPressed)
        {
            buttonRectTransform.gameObject.SetActive(true);
        }
        if (gameObject.name == "inputs" && BMenu.inputsPressed)
        {
            targetPosition = new Vector2(newX, newY);
        }
        if (gameObject.name != "inputs" && BMenu.inputsPressed)
        {
            buttonRectTransform.gameObject.SetActive(false);
        }
        if (gameObject.name == "inputs" && !BMenu.inputsPressed)
        {
            targetPosition = originalPosition;
        }
        if (gameObject.name != "inputs" && !BMenu.inputsPressed)
        {
            buttonRectTransform.gameObject.SetActive(true);
        }
        if (gameObject.name == "credits" && BMenu.creditsPressed)
        {
            targetPosition = new Vector2(newX, newY);
        }
        if (gameObject.name != "credits" && BMenu.creditsPressed)
        {
            buttonRectTransform.gameObject.SetActive(false);
        }
        if (gameObject.name == "credits" && !BMenu.creditsPressed)
        {
            targetPosition = originalPosition;
        }
        if (gameObject.name != "credits" && !BMenu.creditsPressed)
        {
            buttonRectTransform.gameObject.SetActive(true);
        }
    }
}
