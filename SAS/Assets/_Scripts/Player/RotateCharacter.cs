using UnityEngine;

[RequireComponent(typeof(PlayerInput))]
public class RotateCharacter : MonoBehaviour
{
    private PlayerInput input;

    private void Awake()
    {
        input = GetComponent<PlayerInput>();
    }

    private void Update()
    {
        if(input.horizontal < 0)
        {
            transform.localScale = new Vector3(1.0f, transform.localScale.y, transform.localScale.z);
        }
        else if(input.horizontal > 0)
        {
            transform.localScale = new Vector3(-1.0f, transform.localScale.y, transform.localScale.z);
        }
    }
}
