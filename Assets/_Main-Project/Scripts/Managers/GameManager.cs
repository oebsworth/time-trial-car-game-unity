using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public enum State
    {
        OrangeCar,
        BlueCar,
        Finished,
    }

    public State state;

    public int currentOrangeBarrelCount;
    public int currentBlueBarrelCount;

    public float currentOrangeTimer;
    public float currentBlueTimer;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        switch (state)
        {
            case State.OrangeCar:
                currentOrangeTimer += Time.deltaTime;
                break;
            case State.BlueCar:
                currentBlueTimer += Time.deltaTime;
                break;
            case State.Finished:

                break;
        }
    }
}
