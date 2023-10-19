using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BlueFinishLine : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finishTimer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<BlueCar>() != null)
        {
            GameManager.Instance.state = GameManager.State.Finished;

            finishTimer.gameObject.SetActive(true);
            finishTimer.text = ((float)GameManager.Instance.currentRedTimer + (float)GameManager.Instance.currentBlueTimer).ToString("#.##");
        }
    }
}
