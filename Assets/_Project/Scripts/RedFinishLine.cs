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

            Camera.main.transform.SetParent(blueCar.transform);
            Camera.main.transform.position = new Vector3(blueCar.transform.position.x, blueCar.transform.position.y, -10f);
            Camera.main.transform.rotation = blueCar.transform.rotation;
        }
    }
}
