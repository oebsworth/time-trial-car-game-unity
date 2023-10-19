using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public enum State
    {
        RedCar,
        BlueCar,
        Finished,
    }

    public State state;

    public int currentRedBarrelCount;
    public int currentBlueBarrelCount;

    private float currentRedTimer;
    private float currentBlueTimer;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        switch (state)
        {
            case State.RedCar:
                currentRedTimer += Time.deltaTime;
                break;
            case State.BlueCar:
                currentBlueTimer += Time.deltaTime;
                break;
            case State.Finished:

                break;
        }
    }
}
