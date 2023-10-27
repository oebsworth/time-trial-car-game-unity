using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtTrigger : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<OrangeCar>() != null || collision.gameObject.GetComponent<BlueCar>() != null)
        {
            OrangeCar.Instance.moveSpeed = 1f;
            BlueCar.Instance.moveSpeed = 1f;
        }
    }
}
