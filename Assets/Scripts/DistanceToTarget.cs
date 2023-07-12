using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceToTarget : MonoBehaviour
{
    public Transform target;
    public bool thisIsClosest = false;

    private void Start()
    {
        target = GameObject.Find("hand").transform;
    }

    private void Update()
    {
        // Obtener todos los objetos con el mismo script en la escena
        DistanceToTarget[] objectsWithScript = FindObjectsOfType<DistanceToTarget>();

        // Variables para almacenar la distancia mínima y el objeto más cercano
        float minDistance = Mathf.Infinity;
        DistanceToTarget closestObject = null;

        // Calcular la distancia de cada objeto al objetivo y encontrar el más cercano
        foreach (DistanceToTarget obj in objectsWithScript)
        {
            float distance = Vector3.Distance(obj.transform.position, target.position);

            if (distance < minDistance)
            {
                minDistance = distance;
                closestObject = obj;
                
            }
        }

        // Establecer la variable "thisIsClosest" en verdadero para el objeto más cercano y falso para los demás
        if (closestObject == this)
        {
            thisIsClosest = true;
        }
        else
        {
            thisIsClosest = false;
        }
    }
}