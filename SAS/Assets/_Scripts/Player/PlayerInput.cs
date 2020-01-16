using UnityEngine;

public abstract class PlayerInput : MonoBehaviour
{
    public float horizontal = 0.0f;
    public float vertical = 0.0f;
    public Vector2 inputDirection = Vector2.zero;

    protected abstract void Update();
}

