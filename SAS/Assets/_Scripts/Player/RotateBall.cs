using UnityEngine;

[RequireComponent(typeof(AccelerationInput))]
public class RotateBall : MonoBehaviour
{
    private AccelerationInput input;
    [SerializeField] private Transform ballTransform;

    private void Awake()
    {
        input = GetComponent<AccelerationInput>();
    }

    private void Update()
    {
        ballTransform.Rotate(Vector3.back * input.horizontal * Time.deltaTime);
    }
}
