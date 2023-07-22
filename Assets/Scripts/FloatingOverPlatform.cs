using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingOverPlatform : MonoBehaviour
{
    public static bool isDoingIt;
    void Start()
    {
        isDoingIt = false;
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("platform"))
        {
            isDoingIt = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("platform"))
        {
            isDoingIt = false;
        }
    }
}
