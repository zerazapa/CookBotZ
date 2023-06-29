using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject hand;
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
    public Transform spawn7;
    public Transform spawn8;
    public Transform spawn9;
    public Transform spawn10;
    
    public float speed = 5f;

    public float hFacing = 0f;

    public bool jPressed = false;
    public bool kPressed = false;
    public bool lHold = false;

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

    public bool spawn1used = false;
    public bool spawn2used = false;
    public bool spawn3used = false;
    public bool spawn4used = false;
    public bool spawn5used = false;
    public bool spawn6used = false;
    public bool spawn7used = false;
    public bool spawn8used = false;
    public bool spawn9used = false;
    public bool spawn10used = false;



    // Start is called before the first frame update
    void Start()
    {
        GameObject spawn1 = GameObject.Find("spawn1");
        GameObject spawn2 = GameObject.Find("spawn2");
        GameObject spawn3 = GameObject.Find("spawn3");
        GameObject spawn4 = GameObject.Find("spawn4");
        GameObject spawn5 = GameObject.Find("spawn5");
        GameObject spawn6 = GameObject.Find("spawn6");
        GameObject spawn7 = GameObject.Find("spawn7");
        GameObject spawn8 = GameObject.Find("spawn8");
        GameObject spawn9 = GameObject.Find("spawn9");
        GameObject spawn10 = GameObject.Find("spawn10");
    }

    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;





        if (Input.GetKeyDown(KeyCode.J) && !jPressed)
        {
            jPressed = true;
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            jPressed = false;
        }

        if (Input.GetKeyDown(KeyCode.K) && !kPressed)
        {
            kPressed = true;
        }
        if (Input.GetKeyUp(KeyCode.K))
        {
            kPressed = false;
        }

        if (Input.GetKeyDown(KeyCode.L) && !lHold)
        {
            lHold = true;
        }
        if (Input.GetKeyUp(KeyCode.L))
        {
            lHold = false;
        }

        if (lHold)
        {

            hand.SetActive(true);
            hand.transform.localPosition = new Vector3 ((0.9f * hFacing) , -0.4f, 0f);

            if (isTouchingDish && kPressed && !isSpawningDish)
            {
                StartCoroutine(SpawnDish());
            }

            if (isTouchingBread1 && kPressed && !isSpawningBread1)
            {
                StartCoroutine(SpawnBread1());
            }

            if (isTouchingBread2 && kPressed && !isSpawningBread2)
            {
                StartCoroutine(SpawnBread2());
            }

            if (isTouchingMeat && kPressed && !isSpawningMeat)
            {
                StartCoroutine(SpawnMeat());
            }

            if (isTouchingCheese && kPressed && !isSpawningCheese)
            {
                StartCoroutine(SpawnCheese());
            }

            if (isTouchingLettuce && kPressed && !isSpawningLettuce)
            {
                StartCoroutine(SpawnLettuce());
            }
        } else
        {
            hand.SetActive(false);
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalMovement = Input.GetAxisRaw("Horizontal");
        float verticalMovement = Input.GetAxisRaw("Vertical");
        transform.position += Vector3.right * horizontalMovement * speed * Time.deltaTime;
        transform.position += Vector3.up * verticalMovement * speed * Time.deltaTime;

        if (horizontalMovement < -0.1f)
        {
            hFacing = -1f;
        }
        else if (horizontalMovement > 0.1f)
        {
            hFacing = 1f;
        }
        
        // Cambiar la posici�n X de los hijos del jugador seg�n hFacing
        foreach (Transform child in transform)
        {
            Vector3 childRotation = child.localRotation.eulerAngles;
            childRotation.y = 0f;
            child.localRotation = Quaternion.Euler(childRotation);

            if (hFacing == 1 || hFacing == -1)
            {
                Vector3 childPosition = child.localPosition;
                childPosition.x = Mathf.Abs(childPosition.x) * hFacing;
                child.localPosition = childPosition;
            }
        }
        
        if (!spawn1used)
        {
            spawn2used = false;
            spawn3used = false;
            spawn4used = false;
            spawn5used = false;
            spawn6used = false;
            spawn7used = false;
            spawn8used = false;
            spawn9used = false;
            spawn10used = false;
        }
        if (!spawn2used)
        {
            spawn3used = false;
            spawn4used = false;
            spawn5used = false;
            spawn6used = false;
            spawn7used = false;
            spawn8used = false;
            spawn9used = false;
            spawn10used = false;
        }
        if (!spawn3used)
        {
            spawn4used = false;
            spawn5used = false;
            spawn6used = false;
            spawn7used = false;
            spawn8used = false;
            spawn9used = false;
            spawn10used = false;
        }
        if (!spawn4used)
        {
            spawn5used = false;
            spawn6used = false;
            spawn7used = false;
            spawn8used = false;
            spawn9used = false;
            spawn10used = false;
        }
        if (!spawn5used)
        {
            spawn6used = false;
            spawn7used = false;
            spawn8used = false;
            spawn9used = false;
            spawn10used = false;
        }
        if (!spawn6used)
        {
            spawn7used = false;
            spawn8used = false;
            spawn9used = false;
            spawn10used = false;
        }
        if (!spawn7used)
        {
            spawn8used = false;
            spawn9used = false;
            spawn10used = false;
        }
        if (!spawn8used)
        {
            spawn9used = false;
            spawn10used = false;
        }
        if (!spawn9used)
        {
            spawn10used = false;
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
        if (spawn7.transform.childCount > 0)
        {
            spawn7used = true;
        }
        else
        {
            spawn7used = false;
        }
        if (spawn8.transform.childCount > 0)
        {
            spawn8used = true;
        }
        else
        {
            spawn8used = false;
        }
        if (spawn9.transform.childCount > 0)
        {
            spawn9used = true;
        }
        else
        {
            spawn9used = false;
        }
        if (spawn10.transform.childCount > 0)
        {
            spawn10used = true;
        }
        else
        {
            spawn10used = false;
        }


        

    }

    private IEnumerator SpawnDish()
    {

        if (isTouchingDish && lHold && !spawn10used && spawn9used && !isSpawningDish)
        {
            isSpawningDish = true;
            yield return new WaitForSeconds(1f);
            GameObject dish = Instantiate(dishPrefab, spawn10.position, spawn10.rotation);
            Rigidbody2D dishRigidbody = dish.GetComponent<Rigidbody2D>();
            dish.transform.SetParent(spawn10);
            isSpawningDish = false;
        }
        if (isTouchingDish && lHold && !spawn9used && spawn8used && !isSpawningDish)
        {
            isSpawningDish = true;
            yield return new WaitForSeconds(1f);
            GameObject dish = Instantiate(dishPrefab, spawn9.position, spawn9.rotation);
            Rigidbody2D dishRigidbody = dish.GetComponent<Rigidbody2D>();
            dish.transform.SetParent(spawn9);
            isSpawningDish = false;
        }
        if (isTouchingDish && lHold && !spawn8used && spawn7used && !isSpawningDish)
        {
            isSpawningDish = true;
            yield return new WaitForSeconds(1f);
            GameObject dish = Instantiate(dishPrefab, spawn8.position, spawn8.rotation);
            Rigidbody2D dishRigidbody = dish.GetComponent<Rigidbody2D>();
            dish.transform.SetParent(spawn8);
            isSpawningDish = false;
        }
        if (isTouchingDish && lHold && !spawn7used && spawn6used && !isSpawningDish)
        {
            isSpawningDish = true;
            yield return new WaitForSeconds(1f);
            GameObject dish = Instantiate(dishPrefab, spawn7.position, spawn7.rotation);
            Rigidbody2D dishRigidbody = dish.GetComponent<Rigidbody2D>();
            dish.transform.SetParent(spawn7);
            isSpawningDish = false;
        }
        if (isTouchingDish && lHold && !spawn6used && spawn5used && !isSpawningDish)
        {
            isSpawningDish = true;
            yield return new WaitForSeconds(1f);
            GameObject dish = Instantiate(dishPrefab, spawn6.position, spawn6.rotation);
            Rigidbody2D dishRigidbody = dish.GetComponent<Rigidbody2D>();
            dish.transform.SetParent(spawn6);
            isSpawningDish = false;
            }
        if (isTouchingDish && lHold && !spawn5used && spawn4used && !isSpawningDish)
        {
            isSpawningDish = true;
            yield return new WaitForSeconds(1f);
            GameObject dish = Instantiate(dishPrefab, spawn5.position, spawn5.rotation);
            Rigidbody2D dishRigidbody = dish.GetComponent<Rigidbody2D>();
            dish.transform.SetParent(spawn5);
            isSpawningDish = false;
        }
        if (isTouchingDish && lHold && !spawn4used && spawn3used && !isSpawningDish)
        {
            isSpawningDish = true;
            yield return new WaitForSeconds(1f);
            GameObject dish = Instantiate(dishPrefab, spawn4.position, spawn4.rotation);
            Rigidbody2D dishRigidbody = dish.GetComponent<Rigidbody2D>();
            dish.transform.SetParent(spawn4);
            isSpawningDish = false;
        }
        if (isTouchingDish && lHold && !spawn3used && spawn2used && !isSpawningDish)
        {
            isSpawningDish = true;
            yield return new WaitForSeconds(1f);
            GameObject dish = Instantiate(dishPrefab, spawn3.position, spawn3.rotation);
            Rigidbody2D dishRigidbody = dish.GetComponent<Rigidbody2D>();
            dish.transform.SetParent(spawn3);
            isSpawningDish = false;
        }
        if (isTouchingDish && lHold && !spawn2used && spawn1used && !isSpawningDish)
        {
            isSpawningDish = true;
            yield return new WaitForSeconds(1f);
            GameObject dish = Instantiate(dishPrefab, spawn2.position, spawn2.rotation);
            Rigidbody2D dishRigidbody = dish.GetComponent<Rigidbody2D>();
            dish.transform.SetParent(spawn2);
            isSpawningDish = false;
        }

        if (isTouchingDish && lHold && !spawn1used && !isSpawningDish)
        {
            isSpawningDish = true;
            yield return new WaitForSeconds(1f);
            GameObject dish = Instantiate(dishPrefab, spawn1.position, spawn1.rotation);
            Rigidbody2D dishRigidbody = dish.GetComponent<Rigidbody2D>();
            dish.transform.SetParent(spawn1);
            isSpawningDish = false;
        }

    }
    private IEnumerator SpawnBread1()
    {

        if (isTouchingBread1 && lHold && !spawn10used && spawn9used && !isSpawningBread1)
        {
            isSpawningBread1 = true;
            yield return new WaitForSeconds(1f);
            GameObject bread1 = Instantiate(bread1Prefab, spawn10.position, spawn10.rotation);
            Rigidbody2D bread1Rigidbody = bread1.GetComponent<Rigidbody2D>();
            bread1.transform.SetParent(spawn10);
            isSpawningBread1 = false;
        }
        if (isTouchingBread1 && lHold && !spawn9used && spawn8used && !isSpawningBread1)
        {
            isSpawningBread1 = true;
            yield return new WaitForSeconds(1f);
            GameObject bread1 = Instantiate(bread1Prefab, spawn9.position, spawn9.rotation);
            Rigidbody2D bread1Rigidbody = bread1.GetComponent<Rigidbody2D>();
            bread1.transform.SetParent(spawn9);
            isSpawningBread1 = false;
        }
        if (isTouchingBread1 && lHold && !spawn8used && spawn7used && !isSpawningBread1)
        {
            isSpawningBread1 = true;
            yield return new WaitForSeconds(1f);
            GameObject bread1 = Instantiate(bread1Prefab, spawn8.position, spawn8.rotation);
            Rigidbody2D bread1Rigidbody = bread1.GetComponent<Rigidbody2D>();
            bread1.transform.SetParent(spawn8);
            isSpawningBread1 = false;
        }
        if (isTouchingBread1 && lHold && !spawn7used && spawn6used && !isSpawningBread1)
        {
            isSpawningBread1 = true;
            yield return new WaitForSeconds(1f);
            GameObject bread1 = Instantiate(bread1Prefab, spawn7.position, spawn7.rotation);
            Rigidbody2D bread1Rigidbody = bread1.GetComponent<Rigidbody2D>();
            bread1.transform.SetParent(spawn7);
            isSpawningBread1 = false;
        }
        if (isTouchingBread1 && lHold && !spawn6used && spawn5used && !isSpawningBread1)
        {
            isSpawningBread1 = true;
            yield return new WaitForSeconds(1f);
            GameObject bread1 = Instantiate(bread1Prefab, spawn6.position, spawn6.rotation);
            Rigidbody2D bread1Rigidbody = bread1.GetComponent<Rigidbody2D>();
            bread1.transform.SetParent(spawn6);
            isSpawningBread1 = false;
        }
        if (isTouchingBread1 && lHold && !spawn5used && spawn4used && !isSpawningBread1)
        {
            isSpawningBread1 = true;
            yield return new WaitForSeconds(1f);
            GameObject bread1 = Instantiate(bread1Prefab, spawn5.position, spawn5.rotation);
            Rigidbody2D bread1Rigidbody = bread1.GetComponent<Rigidbody2D>();
            bread1.transform.SetParent(spawn5);
            isSpawningBread1 = false;
        }
        if (isTouchingBread1 && lHold && !spawn4used && spawn3used && !isSpawningBread1)
        {
            isSpawningBread1 = true;
            yield return new WaitForSeconds(1f);
            GameObject bread1 = Instantiate(bread1Prefab, spawn4.position, spawn4.rotation);
            Rigidbody2D bread1Rigidbody = bread1.GetComponent<Rigidbody2D>();
            bread1.transform.SetParent(spawn4);
            isSpawningBread1 = false;
        }
        if (isTouchingBread1 && lHold && !spawn3used && spawn2used && !isSpawningBread1)
        {
            isSpawningBread1 = true;
            yield return new WaitForSeconds(1f);
            GameObject bread1 = Instantiate(bread1Prefab, spawn3.position, spawn3.rotation);
            Rigidbody2D bread1Rigidbody = bread1.GetComponent<Rigidbody2D>();
            bread1.transform.SetParent(spawn3);
            isSpawningBread1 = false;
        }
        if (isTouchingBread1 && lHold && !spawn2used && spawn1used && !isSpawningBread1)
        {
            isSpawningBread1 = true;
            yield return new WaitForSeconds(1f);
            GameObject bread1 = Instantiate(bread1Prefab, spawn2.position, spawn2.rotation);
            Rigidbody2D bread1Rigidbody = bread1.GetComponent<Rigidbody2D>();
            bread1.transform.SetParent(spawn2);
            isSpawningBread1 = false;
        }

        if (isTouchingBread1 && lHold && !spawn1used && !isSpawningBread1)
        {
            isSpawningBread1 = true;
            yield return new WaitForSeconds(1f);
            GameObject bread1 = Instantiate(bread1Prefab, spawn1.position, spawn1.rotation);
            Rigidbody2D bread1Rigidbody = bread1.GetComponent<Rigidbody2D>();
            bread1.transform.SetParent(spawn1);
            isSpawningBread1 = false;
        }

    }
    private IEnumerator SpawnBread2()
    {

        if (isTouchingBread2 && lHold && !spawn10used && spawn9used && !isSpawningBread2)
        {
            isSpawningBread2 = true;
            yield return new WaitForSeconds(1f);
            GameObject bread2 = Instantiate(bread2Prefab, spawn10.position, spawn10.rotation);
            Rigidbody2D bread2Rigidbody = bread2.GetComponent<Rigidbody2D>();
            bread2.transform.SetParent(spawn10);
            isSpawningBread2 = false;
        }
        if (isTouchingBread2 && lHold && !spawn9used && spawn8used && !isSpawningBread2)
        {
            isSpawningBread2 = true;
            yield return new WaitForSeconds(1f);
            GameObject bread2 = Instantiate(bread2Prefab, spawn9.position, spawn9.rotation);
            Rigidbody2D bread2Rigidbody = bread2.GetComponent<Rigidbody2D>();
            bread2.transform.SetParent(spawn9);
            isSpawningBread2 = false;
        }
        if (isTouchingBread2 && lHold && !spawn8used && spawn7used && !isSpawningBread2)
        {
            isSpawningBread2 = true;
            yield return new WaitForSeconds(1f);
            GameObject bread2 = Instantiate(bread2Prefab, spawn8.position, spawn8.rotation);
            Rigidbody2D bread2Rigidbody = bread2.GetComponent<Rigidbody2D>();
            bread2.transform.SetParent(spawn8);
            isSpawningBread2 = false;
        }
        if (isTouchingBread2 && lHold && !spawn7used && spawn6used && !isSpawningBread2)
        {
            isSpawningBread2 = true;
            yield return new WaitForSeconds(1f);
            GameObject bread2 = Instantiate(bread2Prefab, spawn7.position, spawn7.rotation);
            Rigidbody2D bread2Rigidbody = bread2.GetComponent<Rigidbody2D>();
            bread2.transform.SetParent(spawn7);
            isSpawningBread2 = false;
        }
        if (isTouchingBread2 && lHold && !spawn6used && spawn5used && !isSpawningBread2)
        {
            isSpawningBread2 = true;
            yield return new WaitForSeconds(1f);
            GameObject bread2 = Instantiate(bread2Prefab, spawn6.position, spawn6.rotation);
            Rigidbody2D bread2Rigidbody = bread2.GetComponent<Rigidbody2D>();
            bread2.transform.SetParent(spawn6);
            isSpawningBread2 = false;
        }
        if (isTouchingBread2 && lHold && !spawn5used && spawn4used && !isSpawningBread2)
        {
            isSpawningBread2 = true;
            yield return new WaitForSeconds(1f);
            GameObject bread2 = Instantiate(bread2Prefab, spawn5.position, spawn5.rotation);
            Rigidbody2D bread2Rigidbody = bread2.GetComponent<Rigidbody2D>();
            bread2.transform.SetParent(spawn5);
            isSpawningBread2 = false;
        }
        if (isTouchingBread2 && lHold && !spawn4used && spawn3used && !isSpawningBread2)
        {
            isSpawningBread2 = true;
            yield return new WaitForSeconds(1f);
            GameObject bread2 = Instantiate(bread2Prefab, spawn4.position, spawn4.rotation);
            Rigidbody2D bread2Rigidbody = bread2.GetComponent<Rigidbody2D>();
            bread2.transform.SetParent(spawn4);
            isSpawningBread2 = false;
        }
        if (isTouchingBread2 && lHold && !spawn3used && spawn2used && !isSpawningBread2)
        {
            isSpawningBread2 = true;
            yield return new WaitForSeconds(1f);
            GameObject bread2 = Instantiate(bread2Prefab, spawn3.position, spawn3.rotation);
            Rigidbody2D bread2Rigidbody = bread2.GetComponent<Rigidbody2D>();
            bread2.transform.SetParent(spawn3);
            isSpawningBread2 = false;
        }
        if (isTouchingBread2 && lHold && !spawn2used && spawn1used && !isSpawningBread2)
        {
            isSpawningBread2 = true;
            yield return new WaitForSeconds(1f);
            GameObject bread2 = Instantiate(bread2Prefab, spawn2.position, spawn2.rotation);
            Rigidbody2D bread2Rigidbody = bread2.GetComponent<Rigidbody2D>();
            bread2.transform.SetParent(spawn2);
            isSpawningBread2 = false;
        }

        if (isTouchingBread2 && lHold && !spawn1used && !isSpawningBread2)
        {
            isSpawningBread2 = true;
            yield return new WaitForSeconds(1f);
            GameObject bread2 = Instantiate(bread2Prefab, spawn1.position, spawn1.rotation);
            Rigidbody2D bread2Rigidbody = bread2.GetComponent<Rigidbody2D>();
            bread2.transform.SetParent(spawn1);
            isSpawningBread2 = false;
        }

    }
    private IEnumerator SpawnMeat()
    {

        if (isTouchingMeat && lHold && !spawn10used && spawn9used && !isSpawningMeat)
        {
            isSpawningMeat = true;
            yield return new WaitForSeconds(1f);
            GameObject meat = Instantiate(meatPrefab, spawn10.position, spawn10.rotation);
            Rigidbody2D meatRigidbody = meat.GetComponent<Rigidbody2D>();
            meat.transform.SetParent(spawn10);
            isSpawningMeat = false;
        }
        if (isTouchingMeat && lHold && !spawn9used && spawn8used && !isSpawningMeat)
        {
            isSpawningMeat = true;
            yield return new WaitForSeconds(1f);
            GameObject meat = Instantiate(meatPrefab, spawn9.position, spawn9.rotation);
            Rigidbody2D meatRigidbody = meat.GetComponent<Rigidbody2D>();
            meat.transform.SetParent(spawn9);
            isSpawningMeat = false;
        }
        if (isTouchingMeat && lHold && !spawn8used && spawn7used && !isSpawningMeat)
        {
            isSpawningMeat = true;
            yield return new WaitForSeconds(1f);
            GameObject meat = Instantiate(meatPrefab, spawn8.position, spawn8.rotation);
            Rigidbody2D meatRigidbody = meat.GetComponent<Rigidbody2D>();
            meat.transform.SetParent(spawn8);
            isSpawningMeat = false;
        }
        if (isTouchingMeat && lHold && !spawn7used && spawn6used && !isSpawningMeat)
        {
            isSpawningMeat = true;
            yield return new WaitForSeconds(1f);
            GameObject meat = Instantiate(meatPrefab, spawn7.position, spawn7.rotation);
            Rigidbody2D meatRigidbody = meat.GetComponent<Rigidbody2D>();
            meat.transform.SetParent(spawn7);
            isSpawningMeat = false;
        }
        if (isTouchingMeat && lHold && !spawn6used && spawn5used && !isSpawningMeat)
        {
            isSpawningMeat = true;
            yield return new WaitForSeconds(1f);
            GameObject meat = Instantiate(meatPrefab, spawn6.position, spawn6.rotation);
            Rigidbody2D meatRigidbody = meat.GetComponent<Rigidbody2D>();
            meat.transform.SetParent(spawn6);
            isSpawningMeat = false;
        }
        if (isTouchingMeat && lHold && !spawn5used && spawn4used && !isSpawningMeat)
        {
            isSpawningMeat = true;
            yield return new WaitForSeconds(1f);
            GameObject meat = Instantiate(meatPrefab, spawn5.position, spawn5.rotation);
            Rigidbody2D meatRigidbody = meat.GetComponent<Rigidbody2D>();
            meat.transform.SetParent(spawn5);
            isSpawningMeat = false;
        }
        if (isTouchingMeat && lHold && !spawn4used && spawn3used && !isSpawningMeat)
        {
            isSpawningMeat = true;
            yield return new WaitForSeconds(1f);
            GameObject meat = Instantiate(meatPrefab, spawn4.position, spawn4.rotation);
            Rigidbody2D meatRigidbody = meat.GetComponent<Rigidbody2D>();
            meat.transform.SetParent(spawn4);
            isSpawningMeat = false;
        }
        if (isTouchingMeat && lHold && !spawn3used && spawn2used && !isSpawningMeat)
        {
            isSpawningMeat = true;
            yield return new WaitForSeconds(1f);
            GameObject meat = Instantiate(meatPrefab, spawn3.position, spawn3.rotation);
            Rigidbody2D meatRigidbody = meat.GetComponent<Rigidbody2D>();
            meat.transform.SetParent(spawn3);
            isSpawningMeat = false;
        }
        if (isTouchingMeat && lHold && !spawn2used && spawn1used && !isSpawningMeat)
        {
            isSpawningMeat = true;
            yield return new WaitForSeconds(1f);
            GameObject meat = Instantiate(meatPrefab, spawn2.position, spawn2.rotation);
            Rigidbody2D meatRigidbody = meat.GetComponent<Rigidbody2D>();
            meat.transform.SetParent(spawn2);
            isSpawningMeat = false;
        }

        if (isTouchingMeat && lHold && !spawn1used && !isSpawningMeat)
        {
            isSpawningMeat = true;
            yield return new WaitForSeconds(1f);
            GameObject meat = Instantiate(meatPrefab, spawn1.position, spawn1.rotation);
            Rigidbody2D meatRigidbody = meat.GetComponent<Rigidbody2D>();
            meat.transform.SetParent(spawn1);
            isSpawningMeat = false;
        }

    }
    private IEnumerator SpawnCheese()
    {

        if (isTouchingCheese && lHold && !spawn10used && spawn9used && !isSpawningCheese)
        {
            isSpawningCheese = true;
            yield return new WaitForSeconds(1f);
            GameObject cheese = Instantiate(cheesePrefab, spawn10.position, spawn10.rotation);
            Rigidbody2D cheeseRigidbody = cheese.GetComponent<Rigidbody2D>();
            cheese.transform.SetParent(spawn10);
            isSpawningCheese = false;
        }
        if (isTouchingCheese && lHold && !spawn9used && spawn8used && !isSpawningCheese)
        {
            isSpawningCheese = true;
            yield return new WaitForSeconds(1f);
            GameObject cheese = Instantiate(cheesePrefab, spawn9.position, spawn9.rotation);
            Rigidbody2D cheeseRigidbody = cheese.GetComponent<Rigidbody2D>();
            cheese.transform.SetParent(spawn9);
            isSpawningCheese = false;
        }
        if (isTouchingCheese && lHold && !spawn8used && spawn7used && !isSpawningCheese)
        {
            isSpawningCheese = true;
            yield return new WaitForSeconds(1f);
            GameObject cheese = Instantiate(cheesePrefab, spawn8.position, spawn8.rotation);
            Rigidbody2D cheeseRigidbody = cheese.GetComponent<Rigidbody2D>();
            cheese.transform.SetParent(spawn8);
            isSpawningCheese = false;
        }
        if (isTouchingCheese && lHold && !spawn7used && spawn6used && !isSpawningCheese)
        {
            isSpawningCheese = true;
            yield return new WaitForSeconds(1f);
            GameObject cheese = Instantiate(cheesePrefab, spawn7.position, spawn7.rotation);
            Rigidbody2D cheeseRigidbody = cheese.GetComponent<Rigidbody2D>();
            cheese.transform.SetParent(spawn7);
            isSpawningCheese = false;
        }
        if (isTouchingCheese && lHold && !spawn6used && spawn5used && !isSpawningCheese)
        {
            isSpawningCheese = true;
            yield return new WaitForSeconds(1f);
            GameObject cheese = Instantiate(cheesePrefab, spawn6.position, spawn6.rotation);
            Rigidbody2D cheeseRigidbody = cheese.GetComponent<Rigidbody2D>();
            cheese.transform.SetParent(spawn6);
            isSpawningCheese = false;
        }
        if (isTouchingCheese && lHold && !spawn5used && spawn4used && !isSpawningCheese)
        {
            isSpawningCheese = true;
            yield return new WaitForSeconds(1f);
            GameObject cheese = Instantiate(cheesePrefab, spawn5.position, spawn5.rotation);
            Rigidbody2D cheeseRigidbody = cheese.GetComponent<Rigidbody2D>();
            cheese.transform.SetParent(spawn5);
            isSpawningCheese = false;
        }
        if (isTouchingCheese && lHold && !spawn4used && spawn3used && !isSpawningCheese)
        {
            isSpawningCheese = true;
            yield return new WaitForSeconds(1f);
            GameObject cheese = Instantiate(cheesePrefab, spawn4.position, spawn4.rotation);
            Rigidbody2D cheeseRigidbody = cheese.GetComponent<Rigidbody2D>();
            cheese.transform.SetParent(spawn4);
            isSpawningCheese = false;
        }
        if (isTouchingCheese && lHold && !spawn3used && spawn2used && !isSpawningCheese)
        {
            isSpawningCheese = true;
            yield return new WaitForSeconds(1f);
            GameObject cheese = Instantiate(cheesePrefab, spawn3.position, spawn3.rotation);
            Rigidbody2D cheeseRigidbody = cheese.GetComponent<Rigidbody2D>();
            cheese.transform.SetParent(spawn3);
            isSpawningCheese = false;
        }
        if (isTouchingCheese && lHold && !spawn2used && spawn1used && !isSpawningCheese)
        {
            isSpawningCheese = true;
            yield return new WaitForSeconds(1f);
            GameObject cheese = Instantiate(cheesePrefab, spawn2.position, spawn2.rotation);
            Rigidbody2D cheeseRigidbody = cheese.GetComponent<Rigidbody2D>();
            cheese.transform.SetParent(spawn2);
            isSpawningCheese = false;
        }

        if (isTouchingCheese && lHold && !spawn1used && !isSpawningCheese)
        {
            isSpawningCheese = true;
            yield return new WaitForSeconds(1f);
            GameObject cheese = Instantiate(cheesePrefab, spawn1.position, spawn1.rotation);
            Rigidbody2D cheeseRigidbody = cheese.GetComponent<Rigidbody2D>();
            cheese.transform.SetParent(spawn1);
            isSpawningCheese = false;
        }

    }
    private IEnumerator SpawnLettuce()
    {

        if (isTouchingLettuce && lHold && !spawn10used && spawn9used && !isSpawningLettuce)
        {
            isSpawningLettuce = true;
            yield return new WaitForSeconds(1f);
            GameObject lettuce = Instantiate(lettucePrefab, spawn10.position, spawn10.rotation);
            Rigidbody2D lettuceRigidbody = lettuce.GetComponent<Rigidbody2D>();
            lettuce.transform.SetParent(spawn10);
            isSpawningLettuce = false;
        }
        if (isTouchingLettuce && lHold && !spawn9used && spawn8used && !isSpawningLettuce)
        {
            isSpawningLettuce = true;
            yield return new WaitForSeconds(1f);
            GameObject lettuce = Instantiate(lettucePrefab, spawn9.position, spawn9.rotation);
            Rigidbody2D lettuceRigidbody = lettuce.GetComponent<Rigidbody2D>();
            lettuce.transform.SetParent(spawn9);
            isSpawningLettuce = false;
        }
        if (isTouchingLettuce && lHold && !spawn8used && spawn7used && !isSpawningLettuce)
        {
            isSpawningLettuce = true;
            yield return new WaitForSeconds(1f);
            GameObject lettuce = Instantiate(lettucePrefab, spawn8.position, spawn8.rotation);
            Rigidbody2D lettuceRigidbody = lettuce.GetComponent<Rigidbody2D>();
            lettuce.transform.SetParent(spawn8);
            isSpawningLettuce = false;
        }
        if (isTouchingLettuce && lHold && !spawn7used && spawn6used && !isSpawningLettuce)
        {
            isSpawningLettuce = true;
            yield return new WaitForSeconds(1f);
            GameObject lettuce = Instantiate(lettucePrefab, spawn7.position, spawn7.rotation);
            Rigidbody2D lettuceRigidbody = lettuce.GetComponent<Rigidbody2D>();
            lettuce.transform.SetParent(spawn7);
            isSpawningLettuce = false;
        }
        if (isTouchingLettuce && lHold && !spawn6used && spawn5used && !isSpawningLettuce)
        {
            isSpawningLettuce = true;
            yield return new WaitForSeconds(1f);
            GameObject lettuce = Instantiate(lettucePrefab, spawn6.position, spawn6.rotation);
            Rigidbody2D lettuceRigidbody = lettuce.GetComponent<Rigidbody2D>();
            lettuce.transform.SetParent(spawn6);
            isSpawningLettuce = false;
        }
        if (isTouchingLettuce && lHold && !spawn5used && spawn4used && !isSpawningLettuce)
        {
            isSpawningLettuce = true;
            yield return new WaitForSeconds(1f);
            GameObject lettuce = Instantiate(lettucePrefab, spawn5.position, spawn5.rotation);
            Rigidbody2D lettuceRigidbody = lettuce.GetComponent<Rigidbody2D>();
            lettuce.transform.SetParent(spawn5);
            isSpawningLettuce = false;
        }
        if (isTouchingLettuce && lHold && !spawn4used && spawn3used && !isSpawningLettuce)
        {
            isSpawningLettuce = true;
            yield return new WaitForSeconds(1f);
            GameObject lettuce = Instantiate(lettucePrefab, spawn4.position, spawn4.rotation);
            Rigidbody2D lettuceRigidbody = lettuce.GetComponent<Rigidbody2D>();
            lettuce.transform.SetParent(spawn4);
            isSpawningLettuce = false;
        }
        if (isTouchingLettuce && lHold && !spawn3used && spawn2used && !isSpawningLettuce)
        {
            isSpawningLettuce = true;
            yield return new WaitForSeconds(1f);
            GameObject lettuce = Instantiate(lettucePrefab, spawn3.position, spawn3.rotation);
            Rigidbody2D lettuceRigidbody = lettuce.GetComponent<Rigidbody2D>();
            lettuce.transform.SetParent(spawn3);
            isSpawningLettuce = false;
        }
        if (isTouchingLettuce && lHold && !spawn2used && spawn1used && !isSpawningLettuce)
        {
            isSpawningLettuce = true;
            yield return new WaitForSeconds(1f);
            GameObject lettuce = Instantiate(lettucePrefab, spawn2.position, spawn2.rotation);
            Rigidbody2D lettuceRigidbody = lettuce.GetComponent<Rigidbody2D>();
            lettuce.transform.SetParent(spawn2);
            isSpawningLettuce = false;
        }

        if (isTouchingLettuce && lHold && !spawn1used && !isSpawningLettuce)
        {
            isSpawningLettuce = true;
            yield return new WaitForSeconds(1f);
            GameObject lettuce = Instantiate(lettucePrefab, spawn1.position, spawn1.rotation);
            Rigidbody2D lettuceRigidbody = lettuce.GetComponent<Rigidbody2D>();
            lettuce.transform.SetParent(spawn1);
            isSpawningLettuce = false;
        }

    }




    void OnCollisionStay2D(Collision2D collision)
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

    void OnCollisionExit2D(Collision2D collision)
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