using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private float leftBoundary = -8f;
    private float rightBoundary = 8f;
    private float carSpeed = 30f;

    private bool isMovingLeft = false; 
    private bool isMovingRight = false; 

    void Update()
    {
        if (isMovingLeft && transform.position.x > leftBoundary)
        {
            transform.Translate(Vector3.left * carSpeed * Time.deltaTime);
        }

        if (isMovingRight && transform.position.x < rightBoundary)
        {
            transform.Translate(Vector3.right * carSpeed * Time.deltaTime);
        }
    }

    public void StartMovingLeft()
    {
        isMovingLeft = true;
    }

    public void StopMovingLeft()
    {
        isMovingLeft = false;
    }

    public void StartMovingRight()
    {
        isMovingRight = true;
    }

    public void StopMovingRight()
    {
        isMovingRight = false;
    }
}
