using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedFinishLine : MonoBehaviour
{
    [SerializeField] GameObject redCar;
    [SerializeField] GameObject blueCar;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<RedCar>() != null)
        {
            redCar.GetComponent<RedCar>().enabled = false;
            blueCar.GetComponent<BlueCar>().enabled = true;

            GameManager.Instance.state = GameManager.State.BlueCar;
        }
    }
}
