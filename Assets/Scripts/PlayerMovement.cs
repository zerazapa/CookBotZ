using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject dishPrefab;
    public GameObject breadPrefab;
    public GameObject meatPrefab;
    public GameObject cheesePrefab;
    public GameObject lettucePrefab;
    public Transform spawn;

    public float speed = 5f;
    public bool canDash = true;

    public float hFacing = 0f;

    public bool jPressed = false;
    public bool kPressed = false;
    public bool lHold = false;

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

    public Transform ff;
    public float ffY = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
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
            if (isTouchingDish && kPressed && !isSpawningDish)
            {
                StartCoroutine(SpawnDish());
            }

            if (isTouchingBread && kPressed && !isSpawningBread)
            {
                StartCoroutine(SpawnBread());
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
        
        // Cambiar la posición X de los hijos del jugador según hFacing
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



    }

    private IEnumerator SpawnDish()
    {
        isSpawningDish = true;

        yield return new WaitForSeconds(1f);

        if (isTouchingDish && lHold)
        { 
            GameObject dish = Instantiate(dishPrefab, spawn.position, spawn.rotation);
            Rigidbody2D dishRigidbody = dish.GetComponent<Rigidbody2D>();
            dish.transform.SetParent(transform); // Establecer el jugador como padre del objeto "dish"
            spawn.position += 0.3f * Vector3.up;
        }

        isSpawningDish = false;
    }

    private IEnumerator SpawnBread()
    {
        isSpawningBread = true;

        yield return new WaitForSeconds(1f);

        if (isTouchingBread && lHold)
        {
            GameObject bread = Instantiate(breadPrefab, spawn.position, spawn.rotation);
            Rigidbody2D breadRigidbody = bread.GetComponent<Rigidbody2D>();
            bread.transform.SetParent(transform); // Establecer el jugador como padre del objeto "dish"
            spawn.position += 0.3f * Vector3.up;
        }

        isSpawningBread = false;
    }

    private IEnumerator SpawnMeat()
    {
        isSpawningMeat = true;

        yield return new WaitForSeconds(1f);

        if (isTouchingMeat && lHold)
        {
            GameObject meat = Instantiate(meatPrefab, spawn.position, spawn.rotation);
            Rigidbody2D meatRigidbody = meat.GetComponent<Rigidbody2D>();
            meat.transform.SetParent(transform);
            spawn.position += 0.3f * Vector3.up;
        }
        isSpawningMeat = false;
    }

    private IEnumerator SpawnCheese()
    {
        isSpawningCheese = true;

        yield return new WaitForSeconds(1f);

        if (isTouchingCheese && lHold)
        {
            GameObject cheese = Instantiate(cheesePrefab, spawn.position, spawn.rotation);
            Rigidbody2D cheeseRigidbody = cheese.GetComponent<Rigidbody2D>();
            cheese.transform.SetParent(transform);
            spawn.position += 0.3f * Vector3.up;
        }

        isSpawningCheese = false;
    }

    private IEnumerator SpawnLettuce()
    {
        isSpawningLettuce = true;

        yield return new WaitForSeconds(1f);

        if (isTouchingLettuce && lHold)
        {
            GameObject lettuce = Instantiate(lettucePrefab, spawn.position, spawn.rotation);
            Rigidbody2D lettuceRigidbody = lettuce.GetComponent<Rigidbody2D>();
            lettuce.transform.SetParent(transform);
            spawn.position += 0.3f * Vector3.up;
        }

        isSpawningLettuce = false;
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Dish"))
        {
            isTouchingDish = true;
        }
        if (collision.gameObject.CompareTag("Bread"))
        {
            isTouchingBread = true;
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
        if (collision.gameObject.CompareTag("Bread"))
        {
            isTouchingBread = false;
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
