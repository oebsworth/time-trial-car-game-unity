using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandRoadTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<RedCar>() != null || collision.gameObject.GetComponent<BlueCar>() != null)
        {
            RedCar.Instance.moveSpeed = 2f;
            BlueCar.Instance.moveSpeed = 2f;
        }
    }
}
