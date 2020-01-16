using UnityEngine;

[RequireComponent(typeof(JoystickInput), typeof(Rigidbody2D))]
public class JoystickMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private JoystickInput input;

    [SerializeField] private float movementSpeed = 5.0f;
    [SerializeField] private float jumpForce = 10.0f;
    [SerializeField] private float rayDistance = 0.1f;
    private bool jumpedLastFrame = false;


    private void Awake()
    {
        input = GetComponent<JoystickInput>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        transform.position += Vector3.right * input.horizontal * movementSpeed * Time.deltaTime;
        if (input.vertical > 0.5f)
        {
            if (jumpedLastFrame)
            {
                jumpedLastFrame = false;
                return;
            }

            Jump();
        }
    }

    private void Jump()
    {
        if (!IsGrounded())
            return;

        rb.velocity = Vector2.zero;
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        jumpedLastFrame = true;
    }

    private bool IsGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -transform.up, rayDistance);
        if (hit.collider != null)
            return true;

        return false;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * rayDistance);
    }
}

