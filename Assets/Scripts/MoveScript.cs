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
        
    }
}
