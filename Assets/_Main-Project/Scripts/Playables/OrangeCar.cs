using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeCar : MonoBehaviour
{
    public static OrangeCar Instance { get; private set; } 

    // Movement
    private Vector3 moveAxis;
    public float moveSpeed = 4f;

    // Turning
    private Vector3 turnAxis;
    private float turnSpeed = 80f;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        moveCar();
        turnCar();
    }

    private void moveCar()
    {
        moveAxis = new Vector3(0f, Input.GetAxis("Vertical"), 0f);
        transform.Translate(moveAxis * moveSpeed * Time.deltaTime);
        Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y, -10f);
    }

    private void turnCar()
    {
        turnAxis = new Vector3(0f, 0f, -Input.GetAxis("Horizontal"));
        transform.Rotate(turnAxis * turnSpeed * Time.deltaTime);
    }
}
