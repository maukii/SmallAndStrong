using UnityEngine;

public class JoystickInput : PlayerInput
{
    [SerializeField] private Joystick joystick;


    protected override void Update()
    {
        horizontal = joystick.Horizontal;
        vertical = joystick.Vertical;
        inputDirection = joystick.Direction;
    }
}
