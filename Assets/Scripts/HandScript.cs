using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandScript : MonoBehaviour
{
    public GameObject player;
    public GameObject dishPrefab;
    public GameObject bread1Prefab;
    public GameObject bread2Prefab;
    public GameObject meatPrefab;
    public GameObject cheesePrefab;
    public GameObject lettucePrefab;
    public Transform spawn1;
    public Transform spawn2;
    public Transform spawn3;
    public Transform spawn4;
    public Transform spawn5;
    public Transform spawn6;

    public static bool lToque = false;
    public bool lClick = false;
    public bool rClick = false;
    public bool spacePressed = false;

    public bool isTouchingDish = false;
    public bool isTouchingBread1 = false;
    public bool isTouchingBread2 = false;
    public bool isTouchingMeat = false;
    public bool isTouchingCheese = false;
    public bool isTouchingLettuce = false;
    public static bool isSpawning = false;

    public static bool spawn1used = false;
    public static bool spawn2used = false;
    public static bool spawn3used = false;
    public static bool spawn4used = false;
    public static bool spawn5used = false;
    public static bool spawn6used = false;

    public float hFacing = 1f;

    public PlayerMovement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
    }

    void Update()
    {
        hFacing = playerMovement.hFacing;

        if (Input.GetKey(KeyCode.Mouse0) && !lClick)
        {
            lClick = true;
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            lClick = false;
        }

        if (Input.GetMouseButtonDown(0))
        {
            lToque = true;
        }
        else
        {
            lToque = false;
        }

        if (Input.GetKeyDown(KeyCode.Mouse1) && !rClick)
        {
            rClick = true;
        }
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            rClick = false;
        }

        if (Input.GetKeyDown(KeyCode.Space) && !spacePressed)
        {
            spacePressed = true;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            spacePressed = false;
        }

        if (!spacePressed)
        {
            GetComponent<SpriteRenderer>().enabled = true;
            transform.localPosition = new Vector3 ((0.24f * hFacing), -0.12f, 0f);

            if (isTouchingDish && rClick && !isSpawning && ContarClones.canSpawn)
            {
                StartCoroutine(SpawnDish());
            }

            if (isTouchingBread1 && rClick && !isSpawning && ContarClones.canSpawn)
            {
                StartCoroutine(SpawnBread1());
            }

            if (isTouchingBread2 && rClick && !isSpawning && ContarClones.canSpawn)
            {
                StartCoroutine(SpawnBread2());
            }

            if (isTouchingMeat && rClick && !isSpawning && ContarClones.canSpawn)
            {
                StartCoroutine(SpawnMeat());
            }

            if (isTouchingCheese && rClick && !isSpawning && ContarClones.canSpawn)
            {
                StartCoroutine(SpawnCheese());
            }

            if (isTouchingLettuce && rClick && !isSpawning && ContarClones.canSpawn)
            {
                StartCoroutine(SpawnLettuce());
            }
        } else
        {
            GetComponent<SpriteRenderer>().enabled = false;
        }

        if (!isTouchingDish && !isTouchingBread1 && !isTouchingBread2 && !isTouchingMeat && !isTouchingCheese && !isTouchingLettuce)
        {
            isSpawning = false;
        }
        
        if (!spawn1used)
        {
                spawn2used = false;
                spawn3used = false;
                spawn4used = false;
                spawn5used = false;
                spawn6used = false;
            }
            if (!spawn2used)
            {
                spawn3used = false;
                spawn4used = false;
                spawn5used = false;
                spawn6used = false;
            }
            if (!spawn3used)
            {
                spawn4used = false;
                spawn5used = false;
                spawn6used = false;
            }
            if (!spawn4used)
            {
                spawn5used = false;
                spawn6used = false;
            }
            if (!spawn5used)
            {
                spawn6used = false;
        }

        if (spawn1.transform.childCount > 0)
        {
                spawn1used = true;
            }
            else
            {
                spawn1used = false;
            }
            if (spawn2.transform.childCount > 0)
            {
                spawn2used = true;
            }
            else
            {
                spawn2used = false;
            }
            if (spawn3.transform.childCount > 0)
            {
                spawn3used = true;
            }
            else
            {
                spawn3used = false;
            }
            if (spawn4.transform.childCount > 0)
            {
                spawn4used = true;
            }
            else
            {
                spawn4used = false;
            }
            if (spawn5.transform.childCount > 0)
            {
                spawn5used = true;
            }
            else
            {
                spawn5used = false;
            }
            if (spawn6.transform.childCount > 0)
            {
                spawn6used = true;
            }
            else
            {
                spawn6used = false;
        }
    }


        

    

    private IEnumerator SpawnDish()
    {
        if (isTouchingDish && !spawn1used && !isSpawning)
        {
            isSpawning = true;
            yield return new WaitForSeconds(1f);
            if(isTouchingDish && isSpawning)
            {
                GameObject dish = Instantiate(dishPrefab, spawn1.position, spawn1.rotation);
                Rigidbody2D dishRigidbody = dish.GetComponent<Rigidbody2D>();
                dish.transform.SetParent(spawn1);
                yield return new WaitForSeconds(0.1f);
            }
            isSpawning = false;
        }
	    else if (isTouchingDish && !spawn2used && spawn1used && !isSpawning)
        {
            isSpawning = true;
            yield return new WaitForSeconds(1f);
            if(isTouchingDish && isSpawning)
            {
                GameObject dish = Instantiate(dishPrefab, spawn2.position, spawn2.rotation);
                Rigidbody2D dishRigidbody = dish.GetComponent<Rigidbody2D>();
                dish.transform.SetParent(spawn2);
                yield return new WaitForSeconds(0.1f);
            }
            isSpawning = false;
        }
	    else if (isTouchingDish && !spawn3used && spawn2used && !isSpawning)
        {
            isSpawning = true;
            yield return new WaitForSeconds(1f);
            if(isTouchingDish && isSpawning)
            {
                GameObject dish = Instantiate(dishPrefab, spawn3.position, spawn3.rotation);
                Rigidbody2D dishRigidbody = dish.GetComponent<Rigidbody2D>();
                dish.transform.SetParent(spawn3);
                yield return new WaitForSeconds(0.1f);
            }
            isSpawning = false;
        }
	    else if (isTouchingDish && !spawn4used && spawn3used && !isSpawning)
        {
            isSpawning = true;
            yield return new WaitForSeconds(1f);
            if(isTouchingDish && isSpawning)
            {
                GameObject dish = Instantiate(dishPrefab, spawn4.position, spawn4.rotation);
                Rigidbody2D dishRigidbody = dish.GetComponent<Rigidbody2D>();
                dish.transform.SetParent(spawn4);
                yield return new WaitForSeconds(0.1f);
            }
            isSpawning = false;
        }
	    else if (isTouchingDish && !spawn5used && spawn4used && !isSpawning)
        {
            isSpawning = true;
            yield return new WaitForSeconds(1f);
            if(isTouchingDish && isSpawning)
            {
                GameObject dish = Instantiate(dishPrefab, spawn5.position, spawn5.rotation);
                Rigidbody2D dishRigidbody = dish.GetComponent<Rigidbody2D>();
                dish.transform.SetParent(spawn5);
                yield return new WaitForSeconds(0.1f);
            }
            isSpawning = false;
        }
	    else if (isTouchingDish && !spawn6used && spawn5used && !isSpawning)
        {
            isSpawning = true;
            yield return new WaitForSeconds(1f);
            if(isTouchingDish && isSpawning)
            {
                GameObject dish = Instantiate(dishPrefab, spawn6.position, spawn6.rotation);
                Rigidbody2D dishRigidbody = dish.GetComponent<Rigidbody2D>();
                dish.transform.SetParent(spawn6);
                yield return new WaitForSeconds(0.1f);
            }
            isSpawning = false;
        }
    }

    private IEnumerator SpawnBread1()
    {
        if (isTouchingBread1 && !spawn1used && !isSpawning)
        {
            isSpawning = true;
            yield return new WaitForSeconds(1f);
            if(isTouchingBread1 && isSpawning)
            {
                GameObject bread1 = Instantiate(bread1Prefab, spawn1.position, spawn1.rotation);
                Rigidbody2D bread1Rigidbody = bread1.GetComponent<Rigidbody2D>();
                bread1.transform.SetParent(spawn1);
                yield return new WaitForSeconds(0.1f);
            }
            isSpawning = false;
        }
	    else if (isTouchingBread1 && !spawn2used && spawn1used && !isSpawning)
        {
            isSpawning = true;
            yield return new WaitForSeconds(1f);
            if(isTouchingBread1 && isSpawning)
            {
                GameObject bread1 = Instantiate(bread1Prefab, spawn2.position, spawn2.rotation);
                Rigidbody2D bread1Rigidbody = bread1.GetComponent<Rigidbody2D>();
                bread1.transform.SetParent(spawn2);
                yield return new WaitForSeconds(0.1f);
            }
            isSpawning = false;
        }
	    else if (isTouchingBread1 && !spawn3used && spawn2used && !isSpawning)
        {
            isSpawning = true;
            yield return new WaitForSeconds(1f);
            if(isTouchingBread1 && isSpawning)
            {
                GameObject bread1 = Instantiate(bread1Prefab, spawn3.position, spawn3.rotation);
                Rigidbody2D bread1Rigidbody = bread1.GetComponent<Rigidbody2D>();
                bread1.transform.SetParent(spawn3);
                yield return new WaitForSeconds(0.1f);
            }
            isSpawning = false;
        }
	    else if (isTouchingBread1 && !spawn4used && spawn3used && !isSpawning)
        {
            isSpawning = true;
            yield return new WaitForSeconds(1f);
            if(isTouchingBread1 && isSpawning)
            {
                GameObject bread1 = Instantiate(bread1Prefab, spawn4.position, spawn4.rotation);
                Rigidbody2D bread1Rigidbody = bread1.GetComponent<Rigidbody2D>();
                bread1.transform.SetParent(spawn4);
                yield return new WaitForSeconds(0.1f);
            }
            isSpawning = false;
        }
	    else if (isTouchingBread1 && !spawn5used && spawn4used && !isSpawning)
        {
            isSpawning = true;
            yield return new WaitForSeconds(1f);
            if(isTouchingBread1 && isSpawning)
            {
                GameObject bread1 = Instantiate(bread1Prefab, spawn5.position, spawn5.rotation);
                Rigidbody2D bread1Rigidbody = bread1.GetComponent<Rigidbody2D>();
                bread1.transform.SetParent(spawn5);
                yield return new WaitForSeconds(0.1f);
            }
            isSpawning = false;
        }
	    else if (isTouchingBread1 && !spawn6used && spawn5used && !isSpawning)
        {
            isSpawning = true;
            yield return new WaitForSeconds(1f);
            if(isTouchingBread1 && isSpawning)
            {
                GameObject bread1 = Instantiate(bread1Prefab, spawn6.position, spawn6.rotation);
                Rigidbody2D bread1Rigidbody = bread1.GetComponent<Rigidbody2D>();
                bread1.transform.SetParent(spawn6);
                yield return new WaitForSeconds(0.1f);
            }
            isSpawning = false;
        }
    }

    private IEnumerator SpawnBread2()
    {
        if (isTouchingBread2 && !spawn1used && !isSpawning)
        {
            isSpawning = true;
            yield return new WaitForSeconds(1f);
            if(isTouchingBread2 && isSpawning)
            {
                GameObject bread2 = Instantiate(bread2Prefab, spawn1.position, spawn1.rotation);
                Rigidbody2D bread2Rigidbody = bread2.GetComponent<Rigidbody2D>();
                bread2.transform.SetParent(spawn1);
                yield return new WaitForSeconds(0.1f);
            }
            isSpawning = false;
        }
	    else if (isTouchingBread2 && !spawn2used && spawn1used && !isSpawning)
        {
            isSpawning = true;
            yield return new WaitForSeconds(1f);
            if(isTouchingBread2 && isSpawning)
            {
                GameObject bread2 = Instantiate(bread2Prefab, spawn2.position, spawn2.rotation);
                Rigidbody2D bread2Rigidbody = bread2.GetComponent<Rigidbody2D>();
                bread2.transform.SetParent(spawn2);
                yield return new WaitForSeconds(0.1f);
            }
            isSpawning = false;
        }
	    else if (isTouchingBread2 && !spawn3used && spawn2used && !isSpawning)
        {
            isSpawning = true;
            yield return new WaitForSeconds(1f);
            if(isTouchingBread2 && isSpawning)
            {
                GameObject bread2 = Instantiate(bread2Prefab, spawn3.position, spawn3.rotation);
                Rigidbody2D bread2Rigidbody = bread2.GetComponent<Rigidbody2D>();
                bread2.transform.SetParent(spawn3);
                yield return new WaitForSeconds(0.1f);
            }
            isSpawning = false;
        }
	    else if (isTouchingBread2 && !spawn4used && spawn3used && !isSpawning)
        {
            isSpawning = true;
            yield return new WaitForSeconds(1f);
            if(isTouchingBread2 && isSpawning)
            {
                GameObject bread2 = Instantiate(bread2Prefab, spawn4.position, spawn4.rotation);
                Rigidbody2D bread2Rigidbody = bread2.GetComponent<Rigidbody2D>();
                bread2.transform.SetParent(spawn4);
                yield return new WaitForSeconds(0.1f);
            }
            isSpawning = false;
        }
	    else if (isTouchingBread2 && !spawn5used && spawn4used && !isSpawning)
        {
            isSpawning = true;
            yield return new WaitForSeconds(1f);
            if(isTouchingBread2 && isSpawning)
            {
                GameObject bread2 = Instantiate(bread2Prefab, spawn5.position, spawn5.rotation);
                Rigidbody2D bread2Rigidbody = bread2.GetComponent<Rigidbody2D>();
                bread2.transform.SetParent(spawn5);
                yield return new WaitForSeconds(0.1f);
            }
            isSpawning = false;
        }
	    else if (isTouchingBread2 && !spawn6used && spawn5used && !isSpawning)
        {
            isSpawning = true;
            yield return new WaitForSeconds(1f);
            if(isTouchingBread2 && isSpawning)
            {
                GameObject bread2 = Instantiate(bread2Prefab, spawn6.position, spawn6.rotation);
                Rigidbody2D bread2Rigidbody = bread2.GetComponent<Rigidbody2D>();
                bread2.transform.SetParent(spawn6);
                yield return new WaitForSeconds(0.1f);
            }
            isSpawning = false;
        }
    }

    private IEnumerator SpawnMeat()
    {
        if (isTouchingMeat && !spawn1used && !isSpawning)
        {
            isSpawning = true;
            yield return new WaitForSeconds(1f);
            if(isTouchingMeat && isSpawning)
            {
                GameObject meat = Instantiate(meatPrefab, spawn1.position, spawn1.rotation);
                Rigidbody2D meatRigidbody = meat.GetComponent<Rigidbody2D>();
                meat.transform.SetParent(spawn1);
                yield return new WaitForSeconds(0.1f);
            }
            isSpawning = false;
        }
	    else if (isTouchingMeat && !spawn2used && spawn1used && !isSpawning)
        {
            isSpawning = true;
            yield return new WaitForSeconds(1f);
            if(isTouchingMeat && isSpawning)
            {
                GameObject meat = Instantiate(meatPrefab, spawn2.position, spawn2.rotation);
                Rigidbody2D meatRigidbody = meat.GetComponent<Rigidbody2D>();
                meat.transform.SetParent(spawn2);
                yield return new WaitForSeconds(0.1f);
            }
            isSpawning = false;
        }
	    else if (isTouchingMeat && !spawn3used && spawn2used && !isSpawning)
        {
            isSpawning = true;
            yield return new WaitForSeconds(1f);
            if(isTouchingMeat && isSpawning)
            {
                GameObject meat = Instantiate(meatPrefab, spawn3.position, spawn3.rotation);
                Rigidbody2D meatRigidbody = meat.GetComponent<Rigidbody2D>();
                meat.transform.SetParent(spawn3);
                yield return new WaitForSeconds(0.1f);
            }
            isSpawning = false;
        }
	    else if (isTouchingMeat && !spawn4used && spawn3used && !isSpawning)
        {
            isSpawning = true;
            yield return new WaitForSeconds(1f);
            if(isTouchingMeat && isSpawning)
            {
                GameObject meat = Instantiate(meatPrefab, spawn4.position, spawn4.rotation);
                Rigidbody2D meatRigidbody = meat.GetComponent<Rigidbody2D>();
                meat.transform.SetParent(spawn4);
                yield return new WaitForSeconds(0.1f);
            }
            isSpawning = false;
        }
	    else if (isTouchingMeat && !spawn5used && spawn4used && !isSpawning)
        {
            isSpawning = true;
            yield return new WaitForSeconds(1f);
            if(isTouchingMeat && isSpawning)
            {
                GameObject meat = Instantiate(meatPrefab, spawn5.position, spawn5.rotation);
                Rigidbody2D meatRigidbody = meat.GetComponent<Rigidbody2D>();
                meat.transform.SetParent(spawn5);
                yield return new WaitForSeconds(0.1f);
            }
            isSpawning = false;
        }
	    else if (isTouchingMeat && !spawn6used && spawn5used && !isSpawning)
        {
            isSpawning = true;
            yield return new WaitForSeconds(1f);
            if(isTouchingMeat && isSpawning)
            {
                GameObject meat = Instantiate(meatPrefab, spawn6.position, spawn6.rotation);
                Rigidbody2D meatRigidbody = meat.GetComponent<Rigidbody2D>();
                meat.transform.SetParent(spawn6);
                yield return new WaitForSeconds(0.1f);
            }
            isSpawning = false;
        }
    }

    private IEnumerator SpawnCheese()
    {
        if (isTouchingCheese && !spawn1used && !isSpawning)
        {
            isSpawning = true;
            yield return new WaitForSeconds(1f);
            if(isTouchingCheese && isSpawning)
            {
                GameObject cheese = Instantiate(cheesePrefab, spawn1.position, spawn1.rotation);
                Rigidbody2D cheeseRigidbody = cheese.GetComponent<Rigidbody2D>();
                cheese.transform.SetParent(spawn1);
                yield return new WaitForSeconds(0.1f);
            }
            isSpawning = false;
        }
	    else if (isTouchingCheese && !spawn2used && spawn1used && !isSpawning)
        {
            isSpawning = true;
            yield return new WaitForSeconds(1f);
            if(isTouchingCheese && isSpawning)
            {
                GameObject cheese = Instantiate(cheesePrefab, spawn2.position, spawn2.rotation);
                Rigidbody2D cheeseRigidbody = cheese.GetComponent<Rigidbody2D>();
                cheese.transform.SetParent(spawn2);
                yield return new WaitForSeconds(0.1f);
            }
            isSpawning = false;
        }
	    else if (isTouchingCheese && !spawn3used && spawn2used && !isSpawning)
        {
            isSpawning = true;
            yield return new WaitForSeconds(1f);
            if(isTouchingCheese && isSpawning)
            {
                GameObject cheese = Instantiate(cheesePrefab, spawn3.position, spawn3.rotation);
                Rigidbody2D cheeseRigidbody = cheese.GetComponent<Rigidbody2D>();
                cheese.transform.SetParent(spawn3);
                yield return new WaitForSeconds(0.1f);
            }
            isSpawning = false;
        }
	    else if (isTouchingCheese && !spawn4used && spawn3used && !isSpawning)
        {
            isSpawning = true;
            yield return new WaitForSeconds(1f);
            if(isTouchingCheese && isSpawning)
            {
                GameObject cheese = Instantiate(cheesePrefab, spawn4.position, spawn4.rotation);
                Rigidbody2D cheeseRigidbody = cheese.GetComponent<Rigidbody2D>();
                cheese.transform.SetParent(spawn4);
                yield return new WaitForSeconds(0.1f);
            }
            isSpawning = false;
        }
	    else if (isTouchingCheese && !spawn5used && spawn4used && !isSpawning)
        {
            isSpawning = true;
            yield return new WaitForSeconds(1f);
            if(isTouchingCheese && isSpawning)
            {
                GameObject cheese = Instantiate(cheesePrefab, spawn5.position, spawn5.rotation);
                Rigidbody2D cheeseRigidbody = cheese.GetComponent<Rigidbody2D>();
                cheese.transform.SetParent(spawn5);
                yield return new WaitForSeconds(0.1f);
            }
            isSpawning = false;
        }
	    else if (isTouchingCheese && !spawn6used && spawn5used && !isSpawning)
        {
            isSpawning = true;
            yield return new WaitForSeconds(1f);
            if(isTouchingCheese && isSpawning)
            {
                GameObject cheese = Instantiate(cheesePrefab, spawn6.position, spawn6.rotation);
                Rigidbody2D cheeseRigidbody = cheese.GetComponent<Rigidbody2D>();
                cheese.transform.SetParent(spawn6);
                yield return new WaitForSeconds(0.1f);
            }
            isSpawning = false;
        }
    }

    private IEnumerator SpawnLettuce()
    {
        if (isTouchingLettuce && !spawn1used && !isSpawning)
        {
            isSpawning = true;
            yield return new WaitForSeconds(1f);
            if(isTouchingLettuce && isSpawning)
            {
                GameObject lettuce = Instantiate(lettucePrefab, spawn1.position, spawn1.rotation);
                Rigidbody2D lettuceRigidbody = lettuce.GetComponent<Rigidbody2D>();
                lettuce.transform.SetParent(spawn1);
                yield return new WaitForSeconds(0.1f);
            }
            isSpawning = false;
        }
	    else if (isTouchingLettuce && !spawn2used && spawn1used && !isSpawning)
        {
            isSpawning = true;
            yield return new WaitForSeconds(1f);
            if(isTouchingLettuce && isSpawning)
            {
                GameObject lettuce = Instantiate(lettucePrefab, spawn2.position, spawn2.rotation);
                Rigidbody2D lettuceRigidbody = lettuce.GetComponent<Rigidbody2D>();
                lettuce.transform.SetParent(spawn2);
                yield return new WaitForSeconds(0.1f);
            }
            isSpawning = false;
        }
	    else if (isTouchingLettuce && !spawn3used && spawn2used && !isSpawning)
        {
            isSpawning = true;
            yield return new WaitForSeconds(1f);
            if(isTouchingLettuce && isSpawning)
            {
                GameObject lettuce = Instantiate(lettucePrefab, spawn3.position, spawn3.rotation);
                Rigidbody2D lettuceRigidbody = lettuce.GetComponent<Rigidbody2D>();
                lettuce.transform.SetParent(spawn3);
                yield return new WaitForSeconds(0.1f);
            }
            isSpawning = false;
        }
	    else if (isTouchingLettuce && !spawn4used && spawn3used && !isSpawning)
        {
            isSpawning = true;
            yield return new WaitForSeconds(1f);
            if(isTouchingLettuce && isSpawning)
            {
                GameObject lettuce = Instantiate(lettucePrefab, spawn4.position, spawn4.rotation);
                Rigidbody2D lettuceRigidbody = lettuce.GetComponent<Rigidbody2D>();
                lettuce.transform.SetParent(spawn4);
                yield return new WaitForSeconds(0.1f);
            }
            isSpawning = false;
        }
	    else if (isTouchingLettuce && !spawn5used && spawn4used && !isSpawning)
        {
            isSpawning = true;
            yield return new WaitForSeconds(1f);
            if(isTouchingLettuce && isSpawning)
            {
                GameObject lettuce = Instantiate(lettucePrefab, spawn5.position, spawn5.rotation);
                Rigidbody2D lettuceRigidbody = lettuce.GetComponent<Rigidbody2D>();
                lettuce.transform.SetParent(spawn5);
                yield return new WaitForSeconds(0.1f);
            }
            isSpawning = false;
        }
	    else if (isTouchingLettuce && !spawn6used && spawn5used && !isSpawning)
        {
            isSpawning = true;
            yield return new WaitForSeconds(1f);
            if(isTouchingLettuce && isSpawning)
            {
                GameObject lettuce = Instantiate(lettucePrefab, spawn6.position, spawn6.rotation);
                Rigidbody2D lettuceRigidbody = lettuce.GetComponent<Rigidbody2D>();
                lettuce.transform.SetParent(spawn6);
                yield return new WaitForSeconds(0.1f);
            }
            isSpawning = false;
        }
    }



    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Dish"))
        {
            isTouchingDish = true;
        }
        if (collision.gameObject.CompareTag("Bread1"))
        {
            isTouchingBread1 = true;
        }
        if (collision.gameObject.CompareTag("Bread2"))
        {
            isTouchingBread2 = true;
        }
        if (collision.gameObject.CompareTag("Meat"))
        {
            isTouchingMeat = true;
        }
        if (collision.gameObject.CompareTag("Cheese"))
        {
            isTouchingCheese = true;
        }
        if (collision.gameObject.CompareTag("Lettuce"))
        {
            isTouchingLettuce = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Dish"))
        {
            isTouchingDish = false;
        }
        if (collision.gameObject.CompareTag("Bread1"))
        {
            isTouchingBread1 = false;
        }
        if (collision.gameObject.CompareTag("Bread2"))
        {
            isTouchingBread2 = false;
        }
        if (collision.gameObject.CompareTag("Meat"))
        {
            isTouchingMeat = false;
        }
        if (collision.gameObject.CompareTag("Cheese"))
        {
            isTouchingCheese = false;
        }
        if (collision.gameObject.CompareTag("Lettuce"))
        {
            isTouchingLettuce = false;
        }
    }
}