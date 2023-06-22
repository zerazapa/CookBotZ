using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject platePrefab;
    public Transform plateSpawn;

    public float speed = 5f;
    public bool canDash = true;

    public float hFacing = 0f;

    private bool jHold = false;
    private bool kHold = false;
    private bool lHold = false;

    private bool isTouchingPlate = false;
    private bool isSpawningPlate = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.J) && !jHold)
        {
            jHold = true;
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            jHold = false;
        }

        if (Input.GetKeyDown(KeyCode.K) && !kHold)
        {
            kHold = true;
        }
        if (Input.GetKeyUp(KeyCode.K))
        {
            kHold = false;
        }

        if (Input.GetKeyDown(KeyCode.L) && !lHold)
        {
            lHold = true;
        }
        if (Input.GetKeyUp(KeyCode.L))
        {
            lHold = false;
        }

        if (isTouchingPlate && kHold && !isSpawningPlate)
        {
            StartCoroutine(SpawnPlate());
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

        // Cambiar el eje X de los hijos del jugador según hFacing
        foreach (Transform child in transform)
        {
            
            if (hFacing == -1)
            {
                Vector3 childPosition = child.localPosition;
                childPosition.x = Mathf.Abs(childPosition.x) * hFacing;
                child.localPosition = childPosition;
            }
            
            if (hFacing == 1)
            {
                Vector3 childPosition = child.localPosition;
                childPosition.x = Mathf.Abs(childPosition.x) * hFacing;
                child.localPosition = childPosition;
            }
        }
    }

    private IEnumerator SpawnPlate()
    {
        isSpawningPlate = true;

        Quaternion rotation = Quaternion.Euler(0f, 0f, 0f);
        if (hFacing == -1)
        {
            rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        else if (hFacing == 1)
        {
            rotation = Quaternion.Euler(0f, 0f, 0f);
        }

        GameObject plate = Instantiate(platePrefab, plateSpawn.position, rotation);
        Rigidbody2D plateRigidbody = plate.GetComponent<Rigidbody2D>();
        plate.transform.SetParent(transform); // Establecer el jugador como padre del objeto "plate"
        plateSpawn.position += 0.3f * Vector3.up;

        yield return new WaitForSeconds(1f);
        
        isSpawningPlate = false;
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Plate"))
        {
            isTouchingPlate = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Plate"))
        {
            isTouchingPlate = false;
        }
    }
}
