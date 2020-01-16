using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private Joystick joystick;
    private Gyroscope phoneGyro;

    public float horizontal = 0.0f;
    public float vertical = 0.0f;
    public Vector2 inputDirection = Vector2.zero;

    public Transform rotateObject;
    public Vector3 gyroEuler = Vector3.zero;


    private void Start()
    {
        if (!SystemInfo.supportsGyroscope) 
            return;
        
        phoneGyro = Input.gyro;
        phoneGyro.enabled = true;
    }

    private void Update()
    {
        if(joystick != null)
        {
            // Use joystick inputs

            horizontal = joystick.Horizontal;
            vertical = joystick.Vertical;
            inputDirection = joystick.Direction;
        }
        else if(SystemInfo.supportsGyroscope)
        {
            // Use gyroscope inputs

            rotateObject.rotation = GyroToUnity(phoneGyro.attitude);
            gyroEuler = GyroToUnity(phoneGyro.attitude).eulerAngles;
        }
    }

    private static Quaternion GyroToUnity(Quaternion q)
    {
        return new Quaternion(q.x, q.y, -q.z, -q.w);
    }
}
