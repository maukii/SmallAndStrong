using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NorsuChecker : MonoBehaviour
{
    Vector3 defaultPosition;

    void Start()
    {
        defaultPosition = transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.otherCollider.tag == "Norsu")
        {
            transform.position = new Vector3(defaultPosition.x, defaultPosition.y - 0.1f, defaultPosition.z);
            
        }            
    }
}
