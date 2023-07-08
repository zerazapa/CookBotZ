using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float hFacing = 1f;
    public float facing = 7f;
    public Transform target;

    private Animator animator;
    private Rigidbody2D rb;
    private Vector2 targetDirection;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {        
        
    }

    void FixedUpdate()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        Vector2 moveDirection = new Vector2(moveX, moveY).normalized;
        rb.velocity = moveDirection * speed;

        targetDirection = target.position - transform.position;
        targetDirection.Normalize();

        float targetAngle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;
        animator.SetFloat("TargetX", targetDirection.x);
        animator.SetFloat("TargetY", targetDirection.y);

        if (targetAngle > 90f || targetAngle < -90f)
        {
            hFacing = -1f;
        }
        else
        {
            hFacing = 1f;
        }

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
}
