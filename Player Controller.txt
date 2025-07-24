using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 5f;
    public float jumpForce = 12f;
    public float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;

    [Header("Input Keys")]
    public KeyCode leftKey;
    public KeyCode rightKey;
    public KeyCode jumpKey;

    [Header("Animation")]
    public Animator animator;

    private Rigidbody2D rb;
    private bool isGrounded;
    private Transform groundCheck;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        groundCheck = transform.Find("GroundCheck");
        spriteRenderer = GetComponent<SpriteRenderer>();

        if (groundCheck == null)
        {
            Debug.LogError("GroundCheck transform is missing. Create an empty child named 'GroundCheck'.");
        }
    }

    void Update()
    {
        HandleMovement();
        HandleJump();
        Animate();
    }

    void HandleMovement()
    {
        float move = 0f;
        if (Input.GetKey(leftKey))
        {
            move = -1f;
            spriteRenderer.flipX = true;
        }
        else if (Input.GetKey(rightKey))
        {
            move = 1f;
            spriteRenderer.flipX = false;
        }

        rb.velocity = new Vector2(move * moveSpeed, rb.velocity.y);

        if (animator != null)
        {
            animator.SetFloat("Speed", Mathf.Abs(move));
        }
    }

    void HandleJump()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        if (Input.GetKeyDown(jumpKey) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);

            if (animator != null)
            {
                animator.SetTrigger("Jump");
            }
        }
    }

    void Animate()
    {
        if (animator != null)
        {
            animator.SetBool("Grounded", isGrounded);
        }
    }

    void OnDrawGizmosSelected()
    {
        if (groundCheck != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
        }
    }
}
