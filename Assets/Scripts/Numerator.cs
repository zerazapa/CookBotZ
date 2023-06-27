using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Numerator : MonoBehaviour
{
    public PlayerMovement playerMovement;
    
    public int whichNum = 0;
    public int thisNum = 0;
    public bool canGetNew = false;

    public bool lHold = false;
    public bool kPressed = false;
    
    public Transform Player;
    public Transform spawn;

    // Start is called before the first frame update
    void Start()
    {
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        playerMovement = playerObject.GetComponent<PlayerMovement>(); // Corregir esta línea

        thisNum = playerMovement.whichHold;

        Player = GameObject.FindGameObjectWithTag("Player").transform;
        spawn = GameObject.FindGameObjectWithTag("spawn").transform;
    }


    // Update is called once per frame
    void Update()
    {
        whichNum = playerMovement.whichHold;
        lHold = playerMovement.lHold;
        kPressed = playerMovement.kPressed;

        if (CompareTag("hDish"))
        {
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
        }
        
        if (CompareTag("dDish"))
        {
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        }




        if (thisNum == 1 && !lHold)
        {
            canGetNew = true;
            //drop
        }
        if (thisNum == 2 && !lHold)
        {
            canGetNew = true;
            //drop
        }
        if (thisNum == 3 && !lHold)
        {
            canGetNew = true;
            //drop
        }
        if (thisNum == 4 && !lHold)
        {
            canGetNew = true;
            //drop
        }
        if (thisNum == 5 && !lHold)
        {
            canGetNew = true;
            //drop
        }
        if (thisNum == 6 && !lHold)
        {
            canGetNew = true;
            //drop
        }
        if (thisNum == 7 && !lHold)
        {
            canGetNew = true;
            //drop
        }
        if (thisNum == 8 && !lHold)
        {
            canGetNew = true;
            //drop
        }
        if (thisNum == 9 && !lHold)
        {
            canGetNew = true;
            //drop
        }
        if (thisNum == 10 && !lHold)
        {
            canGetNew = true;
            //drop
        }

        if (!lHold && gameObject.CompareTag("hDish"))
        {
            StartCoroutine(Drop());
        }
        
    }

    private IEnumerator Drop()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        gameObject.tag = "dDish";
        transform.SetParent(null);
        spawn.localPosition = new Vector3 (0.9f, -0.2f, 0f);
        rb.gravityScale = 2f;
        yield return new WaitForSeconds(0.2f);
        rb.gravityScale = 0f;
        rb.velocity = new Vector2 (0f, 0f);
    }

    private IEnumerator Grab()
    {
        gameObject.tag = "hDish";
        transform.SetParent(spawn);
        transform.localPosition = Vector3.zero;
        transform.SetParent(null);
        yield return new WaitForSeconds(0.1f);
        transform.SetParent(Player);
        spawn.position += 0.3f * Vector3.up;
        playerMovement.whichHold += 1;
    }
    
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (lHold && kPressed && canGetNew)
            {
                thisNum = whichNum;
                canGetNew = false;
            }
        }

        if (lHold && kPressed && gameObject.CompareTag("dDish"))
            {
                StartCoroutine(Grab());
            }
    }

    
}
