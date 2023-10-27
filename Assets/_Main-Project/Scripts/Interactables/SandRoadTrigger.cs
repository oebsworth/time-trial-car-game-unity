using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandRoadTrigger : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<OrangeCar>() != null || collision.gameObject.GetComponent<BlueCar>() != null)
        {
            OrangeCar.Instance.moveSpeed = 2f;
            BlueCar.Instance.moveSpeed = 2f;
        }
    }
}
