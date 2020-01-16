using UnityEngine;

public class LockMobileOrientation : MonoBehaviour
{

    [SerializeField] private ScreenOrientation lockOritentation;

    private void Start()
    {
        Screen.orientation = lockOritentation;
    }
}
