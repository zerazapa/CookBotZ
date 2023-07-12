using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiInteraction : MonoBehaviour
{
    public HandScript handScript;
    public bool lToque = false;
    public float playX;
    public float playY;
    public float pauseX;
    public float pauseY;
    public bool isPlaying = true;
    
    void Start()
    {
        GameObject handObject = GameObject.FindGameObjectWithTag("hand");
        handScript = handObject.GetComponent<HandScript>();
    }

    void Update()
    {
        lToque = handScript.lToque;
        Debug.Log(isPlaying);

        if (isPlaying && gameObject.CompareTag("movableUi"))
        {
            transform.position = new Vector2(playX, playY);
        }
   else if (!isPlaying && gameObject.CompareTag("movableUi"))
        {
            transform.position = new Vector2(pauseX, pauseY);
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("mouse") && lToque && isPlaying)
        {
            Debug.Log("YAPO");
            isPlaying = false;
        }
        if (collision.gameObject.CompareTag("mouse") && lToque && !isPlaying)
        {
            Debug.Log("YAP");
            isPlaying = true;
        }
    }
}
