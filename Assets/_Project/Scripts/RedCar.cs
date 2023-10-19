using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCar : MonoBehaviour
{
    // Movement
    private Vector3 moveAxis;
    private float moveSpeed = 4f;

    // Turning
    private Vector3 turnAxis;
    private float turnSpeed = 80f;

    private void Update()
    {
        moveCar();
        turnCar();
    }

    private void moveCar()
    {
        moveAxis = new Vector3(0f, Input.GetAxis("Vertical"), 0f);
        transform.Translate(moveAxis * moveSpeed * Time.deltaTime);
    }

    private void turnCar()
    {
        turnAxis = new Vector3(0f, 0f, -Input.GetAxis("Horizontal"));
        transform.Rotate(turnAxis * turnSpeed * Time.deltaTime);
    }
}
