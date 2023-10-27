using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeFinishLine : MonoBehaviour
{
    [Header("Cars")]
    [SerializeField] GameObject orangeCar;
    [SerializeField] GameObject blueCar;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<OrangeCar>() != null)
        {
            orangeCar.GetComponent<OrangeCar>().enabled = false;
            blueCar.GetComponent<BlueCar>().enabled = true;

            GameManager.Instance.state = GameManager.State.BlueCar;
        }
    }
}
