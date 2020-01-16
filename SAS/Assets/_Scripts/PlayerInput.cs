using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private Joystick joystick;

    public float horizontal = 0.0f;
    public float vertical = 0.0f;
    public Vector2 inputDirection = Vector2.zero;


    private void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        inputDirection = new Vector2(horizontal, vertical).normalized;

        if(joystick != null)
        {
            horizontal = joystick.Horizontal;
            vertical = joystick.Vertical;

            inputDirection = joystick.Direction;
        }
    }
}
