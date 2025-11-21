using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 5f;
    public float jumpForce = 7f;

    private bool isRunning = false;
    private bool isGrounded = false;

    private Rigidbody2D rb;
    private PlayerHealth health;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        health = GetComponent<PlayerHealth>();
    }



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && !isRunning) isRunning = true;

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) isGrounded = false;




    }

    void FixedUpdate()
    {
        if (isRunning) 
        {
            
            rb.linearVelocity = new Vector2( moveSpeed , rb.linearVelocity.y );

        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other .collider.CompareTag("Ground"))
        {
            isGrounded = true;
        }

        if (other.collider.CompareTag("Obstacle"))
        {
            health.TakeDamag(1);
        }
    }
}
