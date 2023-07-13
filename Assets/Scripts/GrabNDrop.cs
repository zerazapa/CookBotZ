using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabNDrop : MonoBehaviour
{
    public HandScript handScript;
    private PlayerLoading loaderScript;
    private Collider2D childCollider;

    public bool spacePressed = false;
    public bool lClick = false;
    public bool rClick = false;
    
    public Transform Player;
    public Transform hand;
    public Transform spawn1;
    public Transform spawn2;
    public Transform spawn3;
    public Transform spawn4;
    public Transform spawn5;
    public Transform spawn6;

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

    int position = 0;
    public PlayerMovement playerMovement;
    public float hFacing;

    public bool isOnTable = false;

    public bool thisIsClosest = false;
    bool isGrabing = false;
    bool isDropping;
    public static bool canSpawn = true;

    public bool falling = false;

    void Start()
    {
        GameObject handObject = GameObject.FindGameObjectWithTag("hand");
        handScript = handObject.GetComponent<HandScript>();
        GameObject loader = GameObject.Find("loading");
        loaderScript = loader.GetComponent<PlayerLoading>();
        thisIsClosest = GetComponent<DistanceToTarget>();
        GameObject player = GameObject.Find("Player");
        playerMovement = player.GetComponent<PlayerMovement>();
        Transform child = transform.GetChild(0);
        childCollider = transform.GetChild(0).GetComponent<Collider2D>();

        Player = GameObject.Find("Player").transform;
        hand = GameObject.Find("hand").transform;
        spawn1 = GameObject.Find("spawn1").transform;
        spawn2 = GameObject.Find("spawn2").transform;
        spawn3 = GameObject.Find("spawn3").transform;
        spawn4 = GameObject.Find("spawn4").transform;
        spawn5 = GameObject.Find("spawn5").transform;
        spawn6 = GameObject.Find("spawn6").transform;
    }

    void Update()
    {
        Debug.Log(falling);
        spawn1used = handScript.spawn1used;
        spawn2used = handScript.spawn2used;
        spawn3used = handScript.spawn3used;
        spawn4used = handScript.spawn4used;
        spawn5used = handScript.spawn5used;
        spawn6used = handScript.spawn6used;

        isSpawningDish = handScript.isSpawningDish;
        isSpawningBread1 = handScript.isSpawningBread1;
        isSpawningBread2 = handScript.isSpawningBread2;
        isSpawningMeat = handScript.isSpawningMeat;
        isSpawningCheese = handScript.isSpawningCheese;
        isSpawningLettuce = handScript.isSpawningLettuce;

        hFacing = playerMovement.hFacing;

        spacePressed = handScript.spacePressed;
        lClick = handScript.lClick;
        rClick = handScript.rClick;

        if (gameObject.CompareTag("hDish") || gameObject.CompareTag("hBread1") || gameObject.CompareTag("hBread2") || gameObject.CompareTag("hMeat") || gameObject.CompareTag("hCheese") || gameObject.CompareTag("hLettuce"))
        {
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
            childCollider.enabled = false;
        }
        
        if (gameObject.CompareTag("dDish") || gameObject.CompareTag("dBread1") || gameObject.CompareTag("dBread2") || gameObject.CompareTag("dMeat") || gameObject.CompareTag("dCheese") || gameObject.CompareTag("dLettuce"))
        {
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            childCollider.enabled = true;
        }
        

        if (spacePressed && (gameObject.CompareTag("hDish") || gameObject.CompareTag("hBread1") || gameObject.CompareTag("hBread2") || gameObject.CompareTag("hMeat") || gameObject.CompareTag("hCheese") || gameObject.CompareTag("hLettuce")))
        {
            StartCoroutine(DropAll());
        }

        if (lClick && (gameObject.CompareTag("hDish") || gameObject.CompareTag("hBread1") || gameObject.CompareTag("hBread2") || gameObject.CompareTag("hMeat") || gameObject.CompareTag("hCheese") || gameObject.CompareTag("hLettuce")))
        {
            if (spawn1used && !isDropping && !spawn2used && transform.parent.gameObject.name == "spawn1")
            {
                StartCoroutine(Drop1());
            }
            else if (spawn2used && !isDropping && !spawn3used && transform.parent.gameObject.name == "spawn2")
            {
                StartCoroutine(Drop1());
            }
            else if (spawn3used && !isDropping && !spawn4used && transform.parent.gameObject.name == "spawn3")
            {
                StartCoroutine(Drop1());
            }
            else if (spawn4used && !isDropping && !spawn5used && transform.parent.gameObject.name == "spawn4")
            {
                StartCoroutine(Drop1());
            }
            else if (spawn5used && !isDropping && !spawn6used && transform.parent.gameObject.name == "spawn5")
            {
                StartCoroutine(Drop1());
            }
            else if (spawn6used && !isDropping && transform.parent.gameObject.name == "spawn6")
            {
                StartCoroutine(Drop1());
            }            
        }
        
        int cloneCount = CountClones();

        if (cloneCount >= 6)
        {
            canSpawn = false;
        }else
        {
            canSpawn = true;
        }
    }

    int CountClones()
    {
        int count = 0;

        count += CountClonesWithName("Dish(Clone)");
        count += CountClonesWithName("Bread1(Clone)");
        count += CountClonesWithName("Bread2(Clone)");
        count += CountClonesWithName("Meat(Clone)");
        count += CountClonesWithName("Cheese(Clone)");
        count += CountClonesWithName("Lettuce(Clone)");

        return count;
    }

   int CountClonesWithName(string name)
    {
        GameObject[] clones = GameObject.FindObjectsOfType<GameObject>();

        int count = 0;
        foreach (GameObject clone in clones)
        {
            if (clone.name == name)
            {
                count++;
            }
        }

        return count;
    }

    private IEnumerator DropAll()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

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
        rb.gravityScale = (1f);
        if (!falling)
        {
            yield return new WaitForSeconds(0.4f * position);
            rb.gravityScale = 0f;
            rb.velocity = new Vector2(0f, 0f);
        }
        position = 0;
    }

    private IEnumerator Drop1()
    {
        isDropping = true;
        yield return new WaitForSeconds(1f);
        if (lClick)
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();

            if (gameObject.tag == "hDish") //al tag que tuviera, le otorga su contraparte "dropped"
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

            transform.SetParent(hand);
            transform.localPosition = new Vector3 ((0.145f * hFacing) , 0f , 0f);
            transform.SetParent(null);
            rb.gravityScale = (1f);
            if (!falling)
            {
                yield return new WaitForSeconds(0.175f);
                rb.gravityScale = 0f;
                rb.velocity = new Vector2(0f, 0f);
            }
            rb.velocity = new Vector2(0f, 0f);
        }
        isDropping = false;
    }


    private IEnumerator Grab()
    {
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

        if (!spawn1used)
        {
            transform.SetParent(spawn1);
            spawn1used = true;
        }
        else if (!spawn2used && spawn1used)
        {
            transform.SetParent(spawn2);
            spawn2used = true;
        }
        else if (!spawn3used && spawn2used)
        {
            transform.SetParent(spawn3);
            spawn3used = true;
        }
        else if (!spawn4used && spawn3used)
        {
            transform.SetParent(spawn4);
            spawn4used = true;
        }
        else if (!spawn5used && spawn4used)
        {
            transform.SetParent(spawn5);
            spawn5used = true;
        }
        else if (!spawn6used && spawn5used)
        {
            transform.SetParent(spawn6);
            spawn6used = true;
        }

        transform.localPosition = Vector3.zero;
        yield return new WaitForSeconds(1f);
        isGrabing = false;
    }
    
    void OnCollisionStay2D(Collision2D collision)
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        if (!falling && (gameObject.CompareTag("dDish") || gameObject.CompareTag("dBread1") || gameObject.CompareTag("dBread2") || gameObject.CompareTag("dCheese") || gameObject.CompareTag("dLettuce")) && !falling)
        {
            rb.gravityScale = 0f;
            rb.velocity = new Vector2(0f, 0f);
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (!spacePressed && rClick && collision.gameObject.CompareTag("hand") && !spawn6used && !isGrabing)
        {
            isGrabing = true;
            StartCoroutine(Grab());
        }
        
        if (collision.gameObject.CompareTag("platform") && (gameObject.CompareTag("hDish") || gameObject.CompareTag("hBread1") || gameObject.CompareTag("hBread2") || gameObject.CompareTag("hCheese") || gameObject.CompareTag("hLettuce")))
        {
            falling = false;
        }

        if (collision.gameObject.CompareTag("table"))
        {
            Debug.Log("aqui");
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("platform") && (gameObject.CompareTag("hDish") || gameObject.CompareTag("hBread1") || gameObject.CompareTag("hBread2") || gameObject.CompareTag("hCheese") || gameObject.CompareTag("hLettuce")))
        {
            falling = true;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("despawner"))
        {
            Destroy(gameObject);
        }
    }
    
}