using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Numerator : MonoBehaviour
{
    public PlayerMovement playerMovement;

    public bool lHold = false;
    public bool kPressed = false;
    
    public Transform Player;
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

    public bool isSpawningDish = false;
    public bool isSpawningBread1 = false;
    public bool isSpawningBread2 = false;
    public bool isSpawningMeat = false;
    public bool isSpawningCheese = false;
    public bool isSpawningLettuce = false;

    public static bool spawn1used = false;
    public static bool spawn2used = false;
    public static bool spawn3used = false;
    public static bool spawn4used = false;
    public static bool spawn5used = false;
    public static bool spawn6used = false;
    public static bool spawn7used = false;
    public static bool spawn8used = false;
    public static bool spawn9used = false;
    public static bool spawn10used = false;

    public int position = 1;

    // Start is called before the first frame update
    void Start()
    {
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        playerMovement = playerObject.GetComponent<PlayerMovement>();

        Player = GameObject.Find("Player").transform;
        spawn1 = GameObject.Find("spawn1").transform;
        spawn2 = GameObject.Find("spawn2").transform;
        spawn3 = GameObject.Find("spawn3").transform;
        spawn4 = GameObject.Find("spawn4").transform;
        spawn5 = GameObject.Find("spawn5").transform;
        spawn6 = GameObject.Find("spawn6").transform;
        spawn7 = GameObject.Find("spawn7").transform;
        spawn8 = GameObject.Find("spawn8").transform;
        spawn9 = GameObject.Find("spawn9").transform;
        spawn10 = GameObject.Find("spawn10").transform;
    }


    // Update is called once per frame
    void Update()
    {
        spawn1used = playerMovement.spawn1used;
        spawn2used = playerMovement.spawn2used;
        spawn3used = playerMovement.spawn3used;
        spawn4used = playerMovement.spawn4used;
        spawn5used = playerMovement.spawn5used;
        spawn6used = playerMovement.spawn6used;
        spawn7used = playerMovement.spawn7used;
        spawn8used = playerMovement.spawn8used;
        spawn9used = playerMovement.spawn9used;
        spawn10used = playerMovement.spawn10used;

        isSpawningDish = playerMovement.isSpawningDish;
        isSpawningBread1 = playerMovement.isSpawningBread1;
        isSpawningBread2 = playerMovement.isSpawningBread2;
        isSpawningMeat = playerMovement.isSpawningMeat;
        isSpawningCheese = playerMovement.isSpawningCheese;
        isSpawningLettuce = playerMovement.isSpawningLettuce;

        lHold = playerMovement.lHold;
        kPressed = playerMovement.kPressed;

        if (gameObject.CompareTag("hDish") || gameObject.CompareTag("hBread1") || gameObject.CompareTag("hBread2") || gameObject.CompareTag("hMeat") || gameObject.CompareTag("hCheese") || gameObject.CompareTag("hLettuce"))
        {
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
        }
        
        if (gameObject.CompareTag("dDish") || gameObject.CompareTag("dBread1") || gameObject.CompareTag("dBread2") || gameObject.CompareTag("dMeat") || gameObject.CompareTag("dCheese") || gameObject.CompareTag("dLettuce"))
        {
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        }
        

        if (!lHold && (gameObject.CompareTag("hDish") || gameObject.CompareTag("hBread1") || gameObject.CompareTag("hBread2") || gameObject.CompareTag("hMeat") || gameObject.CompareTag("hCheese") || gameObject.CompareTag("hLettuce")))
        {
            StartCoroutine(Drop());
        }
        
        
    }

    private IEnumerator Drop()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        GetComponent<Collider2D>().enabled = false;

        if (transform.parent.gameObject.name == "spawn1")
        {
            position = 1;
        }
        if (transform.parent.gameObject.name == "spawn2")
        {
            position = 2;
        }
        if (transform.parent.gameObject.name == "spawn3")
        {
            position = 3;
        }
        if (transform.parent.gameObject.name == "spawn4")
        {
            position = 4;
        }
        if (transform.parent.gameObject.name == "spawn5")
        {
            position = 5;
        }
        if (transform.parent.gameObject.name == "spawn6")
        {
            position = 6;
        }
        if (transform.parent.gameObject.name == "spawn7")
        {
            position = 7;
        }
        if (transform.parent.gameObject.name == "spawn8")
        {
            position = 8;
        }
        if (transform.parent.gameObject.name == "spawn9")
        {
            position = 9;
        }
        if (transform.parent.gameObject.name == "spawn10")
        {
            position = 10;
        }

        if (gameObject.tag == "hDish")
        {
            gameObject.tag = "dDish";
        }
        if (gameObject.tag == "hBread1")
        {
            gameObject.tag = "dBread1";
        }
        if (gameObject.tag == "hBread2")
        {
            gameObject.tag = "dBread2";
        }
        if (gameObject.tag == "hMeat")
        {
            gameObject.tag = "dMeat";
        }
        if (gameObject.tag == "hCheese")
        {
            gameObject.tag = "dCheese";
        }
        if (gameObject.tag == "hLettuce")
        {
            gameObject.tag = "dLettuce";
        }

        transform.SetParent(null);
        rb.gravityScale = (1f * position);
        yield return new WaitForSeconds(0.175f);
        rb.gravityScale = 0f;
        rb.velocity = new Vector2(0f, 0f);
        position = 0;
    }

    private IEnumerator Grab()
    {
        GetComponent<Collider2D>().enabled = true;
        if (gameObject.tag == "dDish")
        {
            gameObject.tag = "hDish";
        }
        if (gameObject.tag == "dBread1")
        {
            gameObject.tag = "hBread1";
        }
        if (gameObject.tag == "dBread2")
        {
            gameObject.tag = "hBread2";
        }
        if (gameObject.tag == "dMeat")
        {
            gameObject.tag = "hMeat";
        }
        if (gameObject.tag == "dCheese")
        {
            gameObject.tag = "hCheese";
        }
        if (gameObject.tag == "dLettuce")
        {
            gameObject.tag = "hLettuce";
        }

        if (!spawn10used && spawn9used)
        {
            transform.SetParent(spawn10);
            spawn10used = true;
        }
        if (!spawn9used && spawn8used)
        {
            transform.SetParent(spawn9);
            spawn9used = true;
        }
        if (!spawn8used && spawn7used)
        {
            transform.SetParent(spawn8);
            spawn8used = true;
        }
        if (!spawn7used && spawn6used)
        {
            transform.SetParent(spawn7);
            spawn7used = true;
        }
        if (!spawn6used && spawn5used)
        {
            transform.SetParent(spawn6);
            spawn6used = true;
        }
        if (!spawn5used && spawn4used)
        {
            transform.SetParent(spawn5);
            spawn5used = true;
        }
        if (!spawn4used && spawn3used)
        {
            transform.SetParent(spawn4);
            spawn4used = true;
        }
        if (!spawn3used && spawn2used)
        {
            transform.SetParent(spawn3);
            spawn3used = true;
        }
        if (!spawn2used && spawn1used)
        {
            transform.SetParent(spawn2);
            spawn2used = true;
        }
        if (!spawn1used)
        {
            transform.SetParent(spawn1);
            spawn1used = true;
        }

        transform.localPosition = Vector3.zero;
        yield return new WaitForSeconds(0.1f);
    }
    
    void OnCollisionStay2D(Collision2D collision)
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        if (gameObject.CompareTag("dDish") || gameObject.CompareTag("dBread1") || gameObject.CompareTag("dBread2") || gameObject.CompareTag("dCheese") || gameObject.CompareTag("dLettuce"))
        {
            rb.gravityScale = 0f;
            rb.velocity = new Vector2(0f, 0f);
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log ("tocando");
        if (lHold && kPressed && collision.gameObject.CompareTag("hand") && !spawn10used)
            {
                StartCoroutine(Grab());
            }
    }
    
}
