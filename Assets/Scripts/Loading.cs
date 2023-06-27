using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loading : MonoBehaviour
{
    public PlayerMovement playerMovement;

    public bool isTouchingDish = false;
    public bool isSpawningDish = false;
    public bool isTouchingBread = false;
    public bool isSpawningBread = false;
    public bool isTouchingBread2 = false;
    public bool isSpawningBread2 = false;
    public bool isTouchingMeat = false;
    public bool isSpawningMeat = false;
    public bool isTouchingCheese = false;
    public bool isSpawningCheese = false;
    public bool isTouchingLettuce = false;
    public bool isSpawningLettuce = false;

    public int whichHold; 

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
        isSpawningBread = playerMovement.isSpawningBread;
        isSpawningBread2 = playerMovement.isSpawningBread2;
        isSpawningMeat = playerMovement.isSpawningMeat;
        isSpawningCheese = playerMovement.isSpawningCheese;
        isSpawningLettuce = playerMovement.isSpawningLettuce;

        isTouchingDish = playerMovement.isTouchingDish;
        isTouchingBread = playerMovement.isTouchingBread;
        isTouchingBread2 = playerMovement.isTouchingBread2;
        isTouchingMeat = playerMovement.isTouchingMeat;
        isTouchingCheese = playerMovement.isTouchingCheese;
        isTouchingLettuce = playerMovement.isTouchingLettuce;

        whichHold = playerMovement.whichHold;

        if (transform.parent.gameObject.CompareTag("Dish"))
        {
            if (isSpawningDish && isTouchingDish && whichHold < 10)
            {
                animator.SetBool("load", true);
            }
            else
            {
                animator.SetBool("load", false);
            }
        }

        if (transform.parent.gameObject.CompareTag("Bread"))
        {
            if (isSpawningBread && isTouchingBread && whichHold < 10)
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
            if (isSpawningBread2 && isTouchingBread2 && whichHold < 10)
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
            if (isSpawningMeat && isTouchingMeat && whichHold < 10)
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
            if (isSpawningCheese && isTouchingCheese && whichHold < 10)
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
            if (isSpawningLettuce && isTouchingLettuce && whichHold < 10)
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
