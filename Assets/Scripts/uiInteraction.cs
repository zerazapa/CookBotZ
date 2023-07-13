using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiInteraction : MonoBehaviour
{
    public HandScript handScript;
    public float playX;
    public float playY;
    public float pauseX;
    public float pauseY;
    public static bool isPlaying = true;
    public float movementSpeed = 5f; // Velocidad de movimiento de los objetos

    private Vector2 targetPosition; // Posición objetivo para el desplazamiento gradual

    void Start()
    {
        GameObject handObject = GameObject.FindGameObjectWithTag("hand");
        handScript = handObject.GetComponent<HandScript>();
    }

    void Update()
    {
        bool localLToque = HandScript.lToque;
        HandScript.lToque = false; // Restablece lToque a false

        if (isPlaying && gameObject.CompareTag("movableUi"))
        {
            targetPosition = new Vector2(playX, playY);
        }
        else if (!isPlaying && gameObject.CompareTag("movableUi"))
        {
            targetPosition = new Vector2(pauseX, pauseY);
        }



        // Desplazamiento gradual utilizando la interpolación suave (lerp)
        transform.position = Vector2.Lerp(transform.position, targetPosition, movementSpeed * Time.deltaTime);

        // Actualizar las posiciones de los colliders hijos
        UpdateChildCollidersPositions();
    }


    void UpdateChildCollidersPositions()
    {
        Collider2D[] childColliders = GetComponentsInChildren<Collider2D>(true);
        foreach (Collider2D collider in childColliders)
        {
            collider.transform.position = transform.position;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("mouse"))
        {
            isPlaying = false;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("mouse"))
        {
            isPlaying = true;
        }
    }
}
