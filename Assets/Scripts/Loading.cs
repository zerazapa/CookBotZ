using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loading : MonoBehaviour
{
    public PlayerMovement playerMovement;

    public bool isTouchingDish = false;
    public bool isSpawningDish = false;
    public bool isTouchingBread1 = false;
    public bool isSpawningBread1 = false;
    public bool isTouchingBread2 = false;
    public bool isSpawningBread2 = false;
    public bool isTouchingMeat = false;
    public bool isSpawningMeat = false;
    public bool isTouchingCheese = false;
    public bool isSpawningCheese = false;
    public bool isTouchingLettuce = false;
    public bool isSpawningLettuce = false;

    public bool spawn10used; 

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        PlayerMovement playerMovement = playerObject.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        isSpawningDish = playerMovement.isSpawningDish;
        isSpawningBread1 = playerMovement.isSpawningBread1;
        isSpawningBread2 = playerMovement.isSpawningBread2;
        isSpawningMeat = playerMovement.isSpawningMeat;
        isSpawningCheese = playerMovement.isSpawningCheese;
        isSpawningLettuce = playerMovement.isSpawningLettuce;

        isTouchingDish = playerMovement.isTouchingDish;
        isTouchingBread1 = playerMovement.isTouchingBread1;
        isTouchingBread2 = playerMovement.isTouchingBread2;
        isTouchingMeat = playerMovement.isTouchingMeat;
        isTouchingCheese = playerMovement.isTouchingCheese;
        isTouchingLettuce = playerMovement.isTouchingLettuce;


        spawn10used = Numerator.spawn10used;

        if (transform.parent.gameObject.CompareTag("Dish"))
        {
            if (isSpawningDish && isTouchingDish && !spawn10used)
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
            if (isSpawningBread1 && isTouchingBread1 && !spawn10used)
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
            if (isSpawningBread2 && isTouchingBread2 && !spawn10used)
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
            if (isSpawningMeat && isTouchingMeat && !spawn10used)
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
            if (isSpawningCheese && isTouchingCheese && !spawn10used)
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
            if (isSpawningLettuce && isTouchingLettuce && !spawn10used)
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
