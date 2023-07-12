using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontOrBehind : MonoBehaviour
{
    public int layerUp = 10;
    public int layerDown = 1;

    private SpriteRenderer sr;
    public Transform target;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    public void Update()
    {
        if (target.transform.position.y < transform.position.y)
        {
            sr.sortingOrder = layerDown;
        }
        else
        {
            sr.sortingOrder = layerUp;
        }
    }
}