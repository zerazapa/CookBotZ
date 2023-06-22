using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hold : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public bool lHold = false;
    public bool kPressed = false;

    public Transform Player;
    public Transform spawn;


    // Start is called before the first frame update
    void Start()
    {
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        playerMovement = playerObject.GetComponent<PlayerMovement>();
        spawn = GameObject.FindGameObjectWithTag("spawn").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        kPressed = playerMovement.kPressed;
        lHold = playerMovement.lHold;

        if (!lHold && gameObject.CompareTag("hDish"))
        {
            StartCoroutine(Drop());
        }
        
    }

    private IEnumerator Drop()     // al disparar está disparando, se activa la animación de ataque y pasados 3 segundos ya no está disparando
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        gameObject.tag = "dDish";
        transform.SetParent(null);
        spawn.position = new Vector3 (0.9f, -0.2f, 0f);
        rb.gravityScale = 2f;
        yield return new WaitForSeconds(0.3f);
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
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (lHold && kPressed && gameObject.CompareTag("dDish"))
            {
                StartCoroutine(Grab());
            }
        }
    }
}
