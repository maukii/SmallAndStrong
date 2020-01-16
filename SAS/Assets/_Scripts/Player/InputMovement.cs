using UnityEngine;

[RequireComponent(typeof(PlayerInput), typeof(Rigidbody2D))]
public class InputMovement : MonoBehaviour
{
    private PlayerInput input;
    private Rigidbody2D rb;

    [SerializeField] private float movementSpeed = 5.0f;
    [SerializeField] private float jumpForce = 10.0f;


    private void Awake()
    {
        input = GetComponent<PlayerInput>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        transform.position += Vector3.right * input.horizontal * movementSpeed * Time.deltaTime;
    }

    public void Jump()
    {
        if (!IsGrounded()) 
            return;

        rb.velocity += Vector2.up * jumpForce * Time.deltaTime;
    }

    private bool IsGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.1f);
        if (hit.collider != null) 
            return true;
        
        return false;
    }

}
