using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CurrentTimerUI : MonoBehaviour
{
    [Header("Timers")]
    [SerializeField] TextMeshProUGUI orangeTimer;
    [SerializeField] TextMeshProUGUI blueTimer;

    private void Update()
    {
        if (GameManager.Instance.state == GameManager.State.OrangeCar)
        {
            UpdateTimerText(orangeTimer, "Orange", GameManager.Instance.currentOrangeTimer);
        }
        else if (GameManager.Instance.state == GameManager.State.BlueCar)
        {
            UpdateTimerText(blueTimer, "Blue", GameManager.Instance.currentBlueTimer);
        }
    }

    private void UpdateTimerText(TextMeshProUGUI timer, string name, float value)
    {
            timer.text = $"{name}: {value.ToString("0.00")}";
    }
}
