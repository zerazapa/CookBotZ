using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loading : MonoBehaviour
{
    public bool isTouchingDish = false;
    public bool isTouchingBread1 = false;
    public bool isTouchingBread2 = false;
    public bool isTouchingMeat = false;
    public bool isTouchingCheese = false;
    public bool isTouchingLettuce = false;

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
        isTouchingDish = handScript.isTouchingDish;
        isTouchingBread1 = handScript.isTouchingBread1;
        isTouchingBread2 = handScript.isTouchingBread2;
        isTouchingMeat = handScript.isTouchingMeat;
        isTouchingCheese = handScript.isTouchingCheese;
        isTouchingLettuce = handScript.isTouchingLettuce;

        if (transform.parent.gameObject.CompareTag("Dish"))
        {
            if (HandScript.isSpawning && isTouchingDish && !HandScript.spawn6used)
            {
                animator.SetBool("load", true);
            }
            else
            {
                animator.SetBool("load", false);
            }
        }

        if (transform.parent.gameObject.CompareTag("Bread1"))
        {
            if (HandScript.isSpawning && isTouchingBread1 && !HandScript.spawn6used)
            {
                animator.SetBool("load", true);
            }
            else
            {
                animator.SetBool("load", false);
            }
        }

        if (transform.parent.gameObject.CompareTag("Bread2"))
        {
            if (HandScript.isSpawning && isTouchingBread2 && !HandScript.spawn6used)
            {
                animator.SetBool("load", true);
            }
            else
            {
                animator.SetBool("load", false);
            }
        }

        if (transform.parent.gameObject.CompareTag("Meat"))
        {
            if (HandScript.isSpawning && isTouchingMeat && !HandScript.spawn6used)
            {
                animator.SetBool("load", true);
            }
            else
            {
                animator.SetBool("load", false);
            }
        }

        if (transform.parent.gameObject.CompareTag("Cheese"))
        {
            if (HandScript.isSpawning && isTouchingCheese && !HandScript.spawn6used)
            {
                animator.SetBool("load", true);
            }
            else
            {
                animator.SetBool("load", false);
            }
        }

        if (transform.parent.gameObject.CompareTag("Lettuce"))
        {
            if (HandScript.isSpawning && isTouchingLettuce && !HandScript.spawn6used)
            {
                animator.SetBool("load", true);
            }
            else
            {
                animator.SetBool("load", false);
            }
        }

    }
}
