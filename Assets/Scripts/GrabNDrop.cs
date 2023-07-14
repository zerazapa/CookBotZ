using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabNDrop : MonoBehaviour
{
    public HandScript handScript;
    public tableScript tableScript;
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

    int position = 0;
    public PlayerMovement playerMovement;
    public float hFacing;

    public bool thisIsClosest = false;
    bool isGrabing = false;
    bool isDropping;
    public static bool canSpawn = true;

    public bool falling = false;

    public Transform place1;
    public Transform place2;
    public Transform place3;
    public Transform place4;
    public Transform place5;
    public Transform place6;
    
    public bool touchingTable = false;
    public bool item1Right = false;
    public bool item2Right = false;
    public bool item3Right = false;
    public bool item4Right = false;
    public bool item5Right = false;
    public bool item6Right = false;
    public bool tieneTTag = false;
    
    

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
        GameObject tableObject = GameObject.FindGameObjectWithTag("table");
        tableScript = tableObject.GetComponent<tableScript>();

        Player = GameObject.Find("Player").transform;
        hand = GameObject.Find("hand").transform;
        spawn1 = GameObject.Find("spawn1").transform;
        spawn2 = GameObject.Find("spawn2").transform;
        spawn3 = GameObject.Find("spawn3").transform;
        spawn4 = GameObject.Find("spawn4").transform;
        spawn5 = GameObject.Find("spawn5").transform;
        spawn6 = GameObject.Find("spawn6").transform;
        place1 = GameObject.Find("place1").transform;
        place2 = GameObject.Find("place2").transform;
        place3 = GameObject.Find("place3").transform;
        place4 = GameObject.Find("place4").transform;
        place5 = GameObject.Find("place5").transform;
        place6 = GameObject.Find("place6").transform;
    }

    void Update()
    {
        hFacing = playerMovement.hFacing;

        spacePressed = handScript.spacePressed;
        lClick = handScript.lClick;
        rClick = handScript.rClick;

        if (!lClick)
        {
            isDropping = false;
        }

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
        
        if (touchingTable && (gameObject.CompareTag("tDish") || gameObject.CompareTag("tBread1") || gameObject.CompareTag("tBread2") || gameObject.CompareTag("tMeat") || gameObject.CompareTag("tCheese") || gameObject.CompareTag("tLettuce")))
        {
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
            childCollider.enabled = false;
        }
        

        if (spacePressed && (gameObject.CompareTag("hDish") || gameObject.CompareTag("hBread1") || gameObject.CompareTag("hBread2") || gameObject.CompareTag("hMeat") || gameObject.CompareTag("hCheese") || gameObject.CompareTag("hLettuce")))
        {
            StartCoroutine(DropAll());
        }

        if (lClick && (gameObject.CompareTag("hDish") || gameObject.CompareTag("hBread1") || gameObject.CompareTag("hBread2") || gameObject.CompareTag("hMeat") || gameObject.CompareTag("hCheese") || gameObject.CompareTag("hLettuce")))
        {
            if (HandScript.spawn1used && !isDropping && !HandScript.spawn2used && transform.parent.gameObject.name == "spawn1")
            {
                StartCoroutine(Drop1());
            }
            else if (HandScript.spawn2used && !isDropping && !HandScript.spawn3used && transform.parent.gameObject.name == "spawn2")
            {
                StartCoroutine(Drop1());
            }
            else if (HandScript.spawn3used && !isDropping && !HandScript.spawn4used && transform.parent.gameObject.name == "spawn3")
            {
                StartCoroutine(Drop1());
            }
            else if (HandScript.spawn4used && !isDropping && !HandScript.spawn5used && transform.parent.gameObject.name == "spawn4")
            {
                StartCoroutine(Drop1());
            }
            else if (HandScript.spawn5used && !isDropping && !HandScript.spawn6used && transform.parent.gameObject.name == "spawn5")
            {
                StartCoroutine(Drop1());
            }
            else if (HandScript.spawn6used && !isDropping && transform.parent.gameObject.name == "spawn6")
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

        if (touchingTable && (item1Right || item2Right || item3Right || item4Right || item5Right || item6Right) && (gameObject.CompareTag("dDish") || gameObject.CompareTag("dBread1") || gameObject.CompareTag("dBread2") || gameObject.CompareTag("dMeat") || gameObject.CompareTag("dCheese") || gameObject.CompareTag("dLettuce")))
        {
            TurnTableTag();
        }//giveTTag

        if (gameObject.CompareTag("tDish") || gameObject.CompareTag("tBread1") || gameObject.CompareTag("tBread2") || gameObject.CompareTag("tMeat") || gameObject.CompareTag("tCheese") || gameObject.CompareTag("tLettuce"))
        {
                tieneTTag = true;
            }
            else
            {
                tieneTTag = false;
        } //tieneTTag?

        if (gameObject.CompareTag("dDish") && !tableScript.place1used)
        {
                item1Right = true;
            }
            else
            {
                item1Right = false;
            }
            if (gameObject.CompareTag("dBread1") && tableScript.place1used && !tableScript.place2used)
            {
                item2Right = true;
            }
            else
            {
                item2Right = false;
            }
            if ((gameObject.CompareTag("dBread2") || gameObject.CompareTag("dMeat") || gameObject.CompareTag("dCheese") || gameObject.CompareTag("dLettuce")) && (tableScript.place2used && !tableScript.place3used))
            {
                item3Right = true;
            }
            else
            {
                item3Right = false;
            }
            if ((gameObject.CompareTag("dBread2") || gameObject.CompareTag("dMeat") || gameObject.CompareTag("dCheese") || gameObject.CompareTag("dLettuce")) && (tableScript.place3used && !tableScript.place4used))
            {
                item4Right = true;
            }
            else
            {
                item4Right = false;
            }
            if ((gameObject.CompareTag("dBread2") || gameObject.CompareTag("dMeat") || gameObject.CompareTag("dCheese") || gameObject.CompareTag("dLettuce")) && (tableScript.place4used && !tableScript.place5used))
            {
                item5Right = true;
            }
            else
            {
                item5Right = false;
            }
            if ((gameObject.CompareTag("dBread2") || gameObject.CompareTag("dMeat") || gameObject.CompareTag("dCheese") || gameObject.CompareTag("dLettuce")) && (tableScript.place5used && !tableScript.place6used))
            {
                item6Right = true;
            }
            else
            {
                item6Right = false;
        } //itemXRight

        if (touchingTable)
        {
            if (!tableScript.place1used && item1Right)
            {
                transform.SetParent(place1);
                transform.localPosition = Vector2.zero;
            }
            else if (!tableScript.place2used && tableScript.place1used && item2Right)
            {
                transform.SetParent(place2);
                transform.localPosition = Vector2.zero;
            }
            else if (!tableScript.place3used && tableScript.place2used && item3Right)
            {
                transform.SetParent(place3);
                transform.localPosition = Vector2.zero;
            }
            else if (!tableScript.place4used && tableScript.place3used && item4Right)
            {
                transform.SetParent(place4);
                transform.localPosition = Vector2.zero;
            }
            else if (!tableScript.place5used && tableScript.place4used && item5Right)
            {
                transform.SetParent(place5);
                transform.localPosition = Vector2.zero;
            }
            else if (!tableScript.place6used && tableScript.place5used && item6Right)
            {
                transform.SetParent(place6);
                transform.localPosition = Vector2.zero;
            }
        }
    }

    void TurnTableTag()
    {
        if (gameObject.tag == "dDish")
            {
                gameObject.tag = "tDish";
            }
            if (gameObject.tag == "dBread1")
            {
                gameObject.tag = "tBread1";
            }
            if (gameObject.tag == "dBread2")
            {
                gameObject.tag = "tBread2";
            }
            if (gameObject.tag == "dMeat")
            {
                gameObject.tag = "tMeat";
            }
            if (gameObject.tag == "dCheese")
            {
                gameObject.tag = "tCheese";
            }
            if (gameObject.tag == "dLettuce")
            {
                gameObject.tag = "tLettuce";
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

        if (touchingTable && (item1Right || item2Right || item3Right || item4Right || item5Right || item6Right))
        {
            TurnTableTag();
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
        if (lClick && isDropping)
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();

            if (gameObject.tag == "hDish") //tag h->d
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

            if (touchingTable && (item1Right || item2Right || item3Right || item4Right || item5Right || item6Right))
            {
                TurnTableTag();
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

        if (!HandScript.spawn1used)
        {
            transform.SetParent(spawn1);
        }
        else if (!HandScript.spawn2used && HandScript.spawn1used)
        {
            transform.SetParent(spawn2);
        }
        else if (!HandScript.spawn3used && HandScript.spawn2used)
        {
            transform.SetParent(spawn3);
        }
        else if (!HandScript.spawn4used && HandScript.spawn3used)
        {
            transform.SetParent(spawn4);
        }
        else if (!HandScript.spawn5used && HandScript.spawn4used)
        {
            transform.SetParent(spawn5);
        }
        else if (!HandScript.spawn6used && HandScript.spawn5used)
        {
            transform.SetParent(spawn6);
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
        if (!spacePressed && rClick && collision.gameObject.CompareTag("hand") && !HandScript.spawn6used && !isGrabing && (gameObject.CompareTag("dDish") || gameObject.CompareTag("dBread1") || gameObject.CompareTag("dBread2") || gameObject.CompareTag("dMeat") || gameObject.CompareTag("dCheese") || gameObject.CompareTag("dLettuce")))
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
            touchingTable = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("platform") && (gameObject.CompareTag("hDish") || gameObject.CompareTag("hBread1") || gameObject.CompareTag("hBread2") || gameObject.CompareTag("hCheese") || gameObject.CompareTag("hLettuce")))
        {
            falling = true;
        }

        if (collision.gameObject.CompareTag("table"))
        {
            touchingTable = false;
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