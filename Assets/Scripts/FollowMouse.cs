using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        // Obtener la posición del mouse en la pantalla
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = -mainCamera.transform.position.z; // Ajustar la profundidad de acuerdo a la posición de la cámara

        // Convertir la posición del mouse de la pantalla al mundo
        Vector3 worldMousePosition = mainCamera.ScreenToWorldPoint(mousePosition);

        // Actualizar la posición del objeto para que coincida con la posición del mouse
        transform.position = worldMousePosition;
    }
}
