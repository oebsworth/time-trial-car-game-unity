using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BlueFinishLine : MonoBehaviour
{
    [Header("Timers")]
    [SerializeField] TextMeshProUGUI finishTimer;

    [Header("Cars")]
    [SerializeField] GameObject blueCar;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<BlueCar>() != null)
        {
            GameManager.Instance.state = GameManager.State.Finished;

            blueCar.GetComponent<BlueCar>().enabled = false;

            finishTimer.gameObject.SetActive(true);
            finishTimer.text = "Finish: " + ((float)GameManager.Instance.currentRedTimer + (float)GameManager.Instance.currentBlueTimer).ToString("0.00");
        }
    }
}
