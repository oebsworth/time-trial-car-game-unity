using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueFinishLine : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<BlueCar>() != null)
        {
            GameManager.Instance.state = GameManager.State.Finished;
        }
    }
}
