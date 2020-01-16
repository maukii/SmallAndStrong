using UnityEngine;

[RequireComponent(typeof(AccelerationInput), typeof(Rigidbody2D))]
public class AccelerationMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private AccelerationInput input;

    [SerializeField] private float movementSpeed = 5.0f;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        input = GetComponent<AccelerationInput>();
    }

    private void Update()
    {
        // TODO:: only when over treshold
        transform.position += Vector3.left * input.horizontal * movementSpeed * Time.deltaTime;
    }
}
