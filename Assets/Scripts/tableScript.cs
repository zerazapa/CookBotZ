using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tableScript : MonoBehaviour
{
   
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("dDish") || collision.gameObject.CompareTag("dBread1") || collision.gameObject.CompareTag("dBread2") || collision.gameObject.CompareTag("dMeat") || collision.gameObject.CompareTag("dCheese") || collision.gameObject.CompareTag("dLettuce"))
        {
            Debug.Log("aquiigual");
        }
    }
}
