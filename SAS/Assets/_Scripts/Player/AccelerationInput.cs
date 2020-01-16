using UnityEngine;

public class AccelerationInput : PlayerInput
{
    protected override void Update()
    {
        horizontal = -Input.acceleration.x;
    }
}
