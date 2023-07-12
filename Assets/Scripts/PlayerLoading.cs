using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoading : MonoBehaviour
{
    bool lClick;
    bool spawn1used;

    private Animator animator;

    public GameObject handObject;
    public HandScript handScript;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        lClick = handScript.lClick;
        spawn1used = handScript.spawn1used;

        if (lClick && spawn1used)
        {
            animator.SetBool("load", true);
        }
        else
        {
            animator.SetBool("load", false);
        }

    }
}
