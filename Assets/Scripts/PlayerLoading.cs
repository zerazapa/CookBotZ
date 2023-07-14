using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoading : MonoBehaviour
{
    bool lClick;
    public bool dropped;

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

        if (lClick && HandScript.spawn1used)
        {
            animator.SetBool("load", true);
        }
        else
        {
            animator.SetBool("load", false);
        }
    }
}
