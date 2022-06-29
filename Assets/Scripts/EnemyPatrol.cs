using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public GameObject leftBorder;
    public GameObject rightBorder;
    public Rigidbody2D rb;
    public GroundDetection groundDetection;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private CollisionDamage collisionDamage;


    public bool isRightDirection;

    public float speed;

    private void Start()
    {
        speed = Random.Range(speed * 0.75f, speed * 1.25f);
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (groundDetection.isGrounded)
        {
            if (transform.position.x > rightBorder.transform.position.x
                || collisionDamage.Direction < 0)
                isRightDirection = false;
            else if (transform.position.x < leftBorder.transform.position.x
                || collisionDamage.Direction > 0)
                isRightDirection = true;
            rb.velocity = isRightDirection ? Vector2.right : Vector2.left;
            rb.velocity *= speed;
        }

        if (rb.velocity.x > 0)
            spriteRenderer.flipX = true;
        if (rb.velocity.x < 0)
            spriteRenderer.flipX = false;


    }
}
