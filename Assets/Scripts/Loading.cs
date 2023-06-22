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
    public bool isTouchingMeat = false;
    public bool isSpawningMeat = false;
    public bool isTouchingCheese = false;
    public bool isSpawningCheese = false;
    public bool isTouchingLettuce = false;
    public bool isSpawningLettuce = false;

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
        isSpawningMeat = playerMovement.isSpawningMeat;
        isSpawningCheese = playerMovement.isSpawningCheese;
        isSpawningLettuce = playerMovement.isSpawningLettuce;

        isTouchingDish = playerMovement.isTouchingDish;
        isTouchingBread = playerMovement.isTouchingBread;
        isTouchingMeat = playerMovement.isTouchingMeat;
        isTouchingCheese = playerMovement.isTouchingCheese;
        isTouchingLettuce = playerMovement.isTouchingLettuce;

        if (transform.parent.gameObject.CompareTag("Dish"))
        {
            if (isSpawningDish && isTouchingDish )
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
            if (isSpawningBread && isTouchingBread)
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
            if (isSpawningMeat && isTouchingMeat)
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
            if (isSpawningCheese && isTouchingCheese)
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
            if (isSpawningLettuce && isTouchingLettuce)
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
